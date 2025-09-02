using AsiscomexOperadorLogistico.Data;
using AsiscomexOperadorLogistico.Models;
using AsiscomexOperadorLogistico.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsiscomexOperadorLogistico.Services
{
    /// <summary>
    /// Servicio para obtener parámetros y listas del sistema
    /// Reemplaza las llamadas a cargarinfo.EjecutarSp del WebForm
    /// </summary>
    public class ParametrosService : IParametrosService
    {
        private readonly AcexGestionContext _context;


        public ParametrosService(AcexGestionContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene lista de proveedores
        /// </summary>
        public async Task<List<SelectOption>> GetProveedoresAsync()
        {
            return await _context.proveedores
                .OrderBy(p => p.nombre)
                .Select(p => new SelectOption
                {
                    Value = p.idproveedor.ToString(),
                    Text = p.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de países
        /// </summary>
        public async Task<List<SelectOption>> GetPaisesAsync()
        {
            return await _context.paises
                .OrderBy(p => p.nombre)
                .Select(p => new SelectOption
                {
                    Value = p.idpais.ToString(),
                    Text = p.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de Incoterms
        /// </summary>
        public async Task<List<SelectOption>> GetIncotermAsync()
        {
            return await _context.incoterms
                .OrderBy(i => i.descripcion)
                .Select(i => new SelectOption
                {
                    Value = i.idincoterm.ToString(),
                    Text = i.descripcion ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de monedas
        /// </summary>
        public async Task<List<SelectOption>> GetMonedasAsync()
        {
            return await _context.monedas
                .OrderBy(m => m.descripcion)
                .Select(m => new SelectOption
                {
                    Value = m.idmoneda.ToString(),
                    Text = m.descripcion ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de modalidades
        /// </summary>
        public async Task<List<SelectOption>> GetModalidadesAsync()
        {
            return await _context.Modalidads
                .OrderBy(m => m.descripcion)
                .Select(m => new SelectOption
                {
                    Value = m.idmodalidad.ToString(),
                    Text = m.descripcion ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de modos de transporte
        /// </summary>
        public async Task<List<SelectOption>> GetModoTransporteAsync()
        {
            return await _context.modotransportes
                .OrderBy(m => m.nombre)
                .Select(m => new SelectOption
                {
                    Value = m.idmodotransporte.ToString(),
                    Text = m.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de tipos de carga
        /// </summary>
        public async Task<List<SelectOption>> GetTipoCargaAsync()
        {
            return await _context.tipocargas
                .OrderBy(t => t.nombre)
                .Select(t => new SelectOption
                {
                    Value = t.idtipocarga.ToString(),
                    Text = t.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de navieras/embarcadores
        /// </summary>
        public async Task<List<SelectOption>> GetNavierasAsync()
        {
            return await _context.Embarcadores
          
                .GroupBy(e => e.nombre)
                .Select(g => new SelectOption
                {
                    Value = g.Max(e => e.idembarcador).ToString(),
                    Text = g.Key ?? ""
                })
                .OrderBy(e => e.Text)
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de agentes internacionales
        /// </summary>
        public async Task<List<SelectOption>> GetAgentesInternacionalesAsync()
        {
            return await _context.agentesenelexteriors
                .OrderBy(a => a.nombre)
                .Select(a => new SelectOption
                {
                    Value = a.idagenteexterior.ToString(),
                    Text = a.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de puertos
        /// </summary>
        public async Task<List<SelectOption>> GetPuertosAsync()
        {
            return await _context.puertoembarques
                .OrderBy(p => p.nombre)
                .Select(p => new SelectOption
                {
                    Value = p.idpuertoembarque.ToString(),
                    Text = p.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de lugares de ingreso de mercancías (sedes)
        /// </summary>
        public async Task<List<SelectOption>> GetLugarIngresoMercanciasAsync()
        {
            return await _context.LugarIngresoMercancias
                .OrderBy(l => l.Descripcion)
                .Select(l => new SelectOption
                {
                    Value = l.idLugarIngresoMercancias.ToString(),
                    Text = l.Descripcion ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de tipos de documentos
        /// </summary>
        public async Task<List<SelectOption>> GetTipoDocumentosAsync(string tipo = "IMPORTACION")
        {
            return await _context.TipoDocumentos
                .Where(t => t.tipo == tipo)
                .OrderBy(t => t.nombre)
                .Select(t => new SelectOption
                {
                    Value = t.iddocumento.ToString(),
                    Text = t.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de aerolíneas
        /// </summary>
        public async Task<List<SelectOption>> GetAerolineasAsync()
        {
            return await _context.Embarcadores
                .Where(e => e.AeroLinea == true)
                .GroupBy(e => e.nombre)
                .Select(g => new SelectOption
                {
                    Value = g.Max(e => e.idembarcador).ToString(),
                    Text = g.Key ?? ""
                })
                .OrderBy(a => a.Text)
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de tamaños de contenedor
        /// </summary>
        public async Task<List<SelectOption>> GetTamanoContenedorAsync()
        {
            return await _context.TamanioContenedorFulls
                .OrderBy(t => t.Nombre)
                .Select(t => new SelectOption
                {
                    Value = t.Id.ToString(),
                    Text = t.Nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de tipos de equipo
        /// </summary>
        public async Task<List<SelectOption>> GetTipoEquipoAsync()
        {
            return await _context.TipoEquipos
                .OrderBy(t => t.nombre)
                .Select(t => new SelectOption
                {
                    Value = t.idtipoequipo.ToString(),
                    Text = t.nombre ?? ""
                })
                .ToListAsync();
        }

        /// <summary>
        /// Obtiene lista de exportadores/importadores
        /// </summary>
        public async Task<List<SelectOption>> GetExportadoresAsync()
        {
            return await _context.exportadors
                .Where(e => e.habilitado == true)
                .OrderBy(e => e.razonsocial)
                .Select(e => new SelectOption
                {
                    Value = e.idexportador.ToString(),
                    Text = e.razonsocial ?? $"{e.primernombre} {e.primerapellido}"
                })
                .ToListAsync();
        }
    }
}