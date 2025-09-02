using AsiscomexOperadorLogistico.Data.Entities;
using AsiscomexOperadorLogistico.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsiscomexOperadorLogistico.Services.Interfaces
{
    /// <summary>
    /// Interfaz para el servicio de gestión de DO
    /// </summary>
    public interface IDOService
    {
        Task<DOControlViewModel> GetDOByIdAsync(int id);
        Task<DOControlViewModel> GetDOByNumberAsync(string nroDO);
        Task<List<DOSearchResult>> SearchDOAsync(string searchTerm);
        Task<int> SaveDOAsync(DOControlViewModel model);
        Task<bool> UpdateDOAsync(DOControlViewModel model);
        Task<bool> CloseDOAsync(int idDO, string estado);
        Task<bool> DuplicateDOAsync(int idDO);
        Task<string> GenerateNewDONumberAsync();
        Task<bool> CheckDuplicateDOAsync(string nroDO);
    }

    /// <summary>
    /// Interfaz para el servicio de exportadores
    /// </summary>
    public interface IExportadorService
    {
        Task<List<SelectOption>> GetExportadoresAsync();
        Task<List<SelectOption>> GetContactosByExportadorAsync(int idExportador);
        Task<exportador> GetExportadorByIdAsync(int id);
        Task<int?> GetSedeComercialByExportadorAsync(int idExportador);
    }

    /// <summary>
    /// Interfaz para el servicio de parámetros y listas
    /// </summary>
    public interface IParametrosService
    {
        Task<List<SelectOption>> GetPaisesAsync();
        Task<List<SelectOption>> GetIncotermAsync();
        Task<List<SelectOption>> GetMonedasAsync();
        Task<List<SelectOption>> GetModalidadesAsync();
        Task<List<SelectOption>> GetModoTransporteAsync();
        Task<List<SelectOption>> GetTipoCargaAsync();
        Task<List<SelectOption>> GetNavierasAsync();
        Task<List<SelectOption>> GetAgentesInternacionalesAsync();
        Task<List<SelectOption>> GetPuertosAsync();
        Task<List<SelectOption>> GetLugarIngresoMercanciasAsync();
        Task<List<SelectOption>> GetTipoDocumentosAsync(string tipo = "IMPORTACION");
        Task<List<SelectOption>> GetAerolineasAsync();
        Task<List<SelectOption>> GetTamanoContenedorAsync();
        Task<List<SelectOption>> GetTipoEquipoAsync();
        Task<List<SelectOption>> GetExportadoresAsync();
        Task<List<SelectOption>> GetProveedoresAsync();


    }

    /// <summary>
    /// Interfaz para el servicio de almacenamiento local
    /// </summary>
    public interface IStorageService
    {
        Task<T> GetItemAsync<T>(string key);
        Task SetItemAsync<T>(string key, T value);
        Task RemoveItemAsync(string key);
        Task ClearAsync();
        Task<bool> ContainKeyAsync(string key);

        // Métodos específicos para sesión
        Task<string> GetUserIdAsync();
        Task SetUserIdAsync(string userId);
        Task<string> GetDOGlobalAsync();
        Task SetDOGlobalAsync(string doGlobal);
        Task<string> GetTipoDOAsync();
        Task SetTipoDOAsync(string tipoDO);
    }

    /// <summary>
    /// Interfaz para el servicio de envío de correos
    /// </summary>
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string to, string subject, string body, bool isHtml = true);
        Task<bool> SendDONotificationAsync(int idDO, string tipo);
    }
}