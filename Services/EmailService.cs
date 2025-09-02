using AsiscomexOperadorLogistico.Data;
using AsiscomexOperadorLogistico.Data.Entities;
using AsiscomexOperadorLogistico.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AsiscomexOperadorLogistico.Services
{
    /// <summary>
    /// Servicio para envío de correos electrónicos
    /// </summary>
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly AcexGestionContext _context;
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPassword;
        private readonly bool _enableSsl;

        public EmailService(IConfiguration configuration, AcexGestionContext context)
        {
            _configuration = configuration;
            _context = context;

            // Leer configuración SMTP desde appsettings.json
            _smtpServer = _configuration["EmailSettings:SmtpServer"] ?? "smtp.gmail.com";
            _smtpPort = int.Parse(_configuration["EmailSettings:SmtpPort"] ?? "587");
            _smtpUser = _configuration["EmailSettings:SmtpUser"] ?? "";
            _smtpPassword = _configuration["EmailSettings:SmtpPassword"] ?? "";
            _enableSsl = bool.Parse(_configuration["EmailSettings:EnableSsl"] ?? "true");
        }

        /// <summary>
        /// Envía un correo electrónico
        /// </summary>
        public async Task<bool> SendEmailAsync(string to, string subject, string body, bool isHtml = true)
        {
            try
            {
                using var message = new MailMessage();
                message.From = new MailAddress(_smtpUser, "Sistema Asiscomex");
                message.To.Add(new MailAddress(to));
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = isHtml;
                message.Priority = MailPriority.Normal;

                using var client = new SmtpClient(_smtpServer, _smtpPort);
                client.EnableSsl = _enableSsl;
                client.Credentials = new NetworkCredential(_smtpUser, _smtpPassword);

                await client.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                // Log del error
                Console.WriteLine($"Error enviando email: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Envía notificación sobre cambios en un DO
        /// </summary>
        public async Task<bool> SendDONotificationAsync(int idDO, string tipo)
        {
            try
            {
                var doEntity = await _context.DOs
                    .FirstOrDefaultAsync(d => d.idDO == idDO);

                if (doEntity == null)
                    return false;

                // Obtener información del exportador
                string exportadorNombre = "";
                if (doEntity.idexportador.HasValue)
                {
                    var exportador = await _context.exportadors
                        .FirstOrDefaultAsync(e => e.idexportador == doEntity.idexportador);
                    exportadorNombre = exportador?.razonsocial ?? "No especificado";
                }

                // Construir el cuerpo del correo
                var body = BuildEmailBody(doEntity, exportadorNombre, tipo);

                // Determinar el asunto según el tipo
                string subject = tipo switch
                {
                    "CREATE" => $"Nuevo DO Creado: {doEntity.NroDO}",
                    "UPDATE" => $"DO Actualizado: {doEntity.NroDO}",
                    "CLOSE" => $"DO Cerrado: {doEntity.NroDO}",
                    _ => $"Notificación DO: {doEntity.NroDO}"
                };

                // Obtener lista de correos a notificar
                // Por ahora usar un correo por defecto, pero esto debería venir de configuración
                string toEmail = _configuration["EmailSettings:NotificationEmail"] ?? "notificaciones@empresa.com";

                return await SendEmailAsync(toEmail, subject, body, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error enviando notificación DO: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Construye el cuerpo HTML del correo
        /// </summary>
        private string BuildEmailBody(DO doEntity, string exportadorNombre, string tipo)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<style>");
            sb.AppendLine("body { font-family: Arial, sans-serif; }");
            sb.AppendLine("table { border-collapse: collapse; width: 100%; }");
            sb.AppendLine("th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }");
            sb.AppendLine("th { background-color: #4CAF50; color: white; }");
            sb.AppendLine(".header { background-color: #f2f2f2; padding: 20px; }");
            sb.AppendLine("</style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");

            // Encabezado
            sb.AppendLine("<div class='header'>");
            sb.AppendLine($"<h2>Notificación de DO - {GetTipoTexto(tipo)}</h2>");
            sb.AppendLine("</div>");

            // Información del DO
            sb.AppendLine("<h3>Información del DO</h3>");
            sb.AppendLine("<table>");
            sb.AppendLine("<tr>");
            sb.AppendLine("<th>Campo</th>");
            sb.AppendLine("<th>Valor</th>");
            sb.AppendLine("</tr>");

            sb.AppendLine("<tr>");
            sb.AppendLine("<td>Número de DO</td>");
            sb.AppendLine($"<td>{doEntity.NroDO}</td>");
            sb.AppendLine("</tr>");

            sb.AppendLine("<tr>");
            sb.AppendLine("<td>Fecha de Creación</td>");
            sb.AppendLine($"<td>{doEntity.FechaCreacion?.ToString("dd/MM/yyyy HH:mm")}</td>");
            sb.AppendLine("</tr>");

            sb.AppendLine("<tr>");
            sb.AppendLine("<td>Exportador</td>");
            sb.AppendLine($"<td>{exportadorNombre}</td>");
            sb.AppendLine("</tr>");

            sb.AppendLine("<tr>");
            sb.AppendLine("<td>Estado</td>");
            sb.AppendLine($"<td>{doEntity.estado}</td>");
            sb.AppendLine("</tr>");

            if (!string.IsNullOrEmpty(doEntity.nropedido))
            {
                sb.AppendLine("<tr>");
                sb.AppendLine("<td>Número de Pedido</td>");
                sb.AppendLine($"<td>{doEntity.nropedido}</td>");
                sb.AppendLine("</tr>");
            }

            if (!string.IsNullOrEmpty(doEntity.observaciones))
            {
                sb.AppendLine("<tr>");
                sb.AppendLine("<td>Observaciones</td>");
                sb.AppendLine($"<td>{doEntity.observaciones}</td>");
                sb.AppendLine("</tr>");
            }

            sb.AppendLine("</table>");

            // Pie del correo
            sb.AppendLine("<br/>");
            sb.AppendLine("<hr/>");
            sb.AppendLine("<p style='font-size: 12px; color: #666;'>");
            sb.AppendLine("Este es un correo automático generado por el Sistema Asiscomex.");
            sb.AppendLine("Por favor no responda a este mensaje.");
            sb.AppendLine("</p>");

            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();
        }

        /// <summary>
        /// Obtiene el texto descriptivo del tipo de operación
        /// </summary>
        private string GetTipoTexto(string tipo)
        {
            return tipo switch
            {
                "CREATE" => "Creación",
                "UPDATE" => "Actualización",
                "CLOSE" => "Cierre",
                _ => "Notificación"
            };
        }
    }
}