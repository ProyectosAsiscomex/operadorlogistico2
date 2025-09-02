using AsiscomexOperadorLogistico.Data;
using AsiscomexOperadorLogistico.Data.Entities;
using AsiscomexOperadorLogistico.Models;
using AsiscomexOperadorLogistico.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsiscomexOperadorLogistico.Services
{
    /// <summary>
    /// Servicio para gestión de exportadores
    /// </summary>
    public class ExportadorService : IExportadorService
    {
        private readonly AcexGestionContext _context;

        public ExportadorService(AcexGestionContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene lista de exportadores activos
        /// </summary>
        public async Task<List<SelectOption>> GetExportadoresAsync()
        {
            return await _context.exportadors
                .Where(e => e.habilitado == true)
                .OrderBy(e => e.razonsocial)
                .Select(e => new SelectOption
                {
                    Value = e.idexportador.ToString(),
                    Text = !string.IsNullOrEmpty(e.razonsocial) ?
                        e.razonsocial :
                        $"{e.primernombre} {e.primerapellido}"
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene los contactos de un exportador específico
        /// </summary>
        public async Task<List<SelectOption>> GetContactosByExportadorAsync(int idExportador)
        {
            return await _context.EncargadosEmpresas
                .Where(e => e.idempresa == idExportador)
                .OrderBy(e => e.Nombre)
                .Select(e => new SelectOption
                {
                    Value = e.idencargado.ToString(),
                    Text = e.Nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene un exportador por su ID
        /// </summary>
        public async Task<exportador> GetExportadorByIdAsync(int id)
        {
            return await _context.exportadors
                .FirstOrDefaultAsync(e => e.idexportador == id);
        }

        /// <summary>
        /// Obtiene la sede comercial asociada al exportador
        /// </summary>
        public async Task<int?> GetSedeComercialByExportadorAsync(int idExportador)
        {
            var exportador = await _context.exportadors
                .FirstOrDefaultAsync(e => e.idexportador == idExportador);

            if (exportador != null && exportador.idciudadgenerodo.HasValue)
            {
                var lugarIngreso = await _context.LugarIngresoMercancias
                    .FirstOrDefaultAsync(l => l.idLugarIngresoMercancias == exportador.idciudadgenerodo.Value);

                if (lugarIngreso != null)
                {
                    return lugarIngreso.idLugarIngresoMercancias;
                }
            }

            return null;
        }
    }
}