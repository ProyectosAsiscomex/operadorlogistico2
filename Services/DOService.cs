using AsiscomexOperadorLogistico.Data;
using AsiscomexOperadorLogistico.Data.Entities;
using AsiscomexOperadorLogistico.Models;
using AsiscomexOperadorLogistico.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsiscomexOperadorLogistico.Services
{
    /// <summary>
    /// Servicio para gestión de DO (Documentos de Operación)
    /// </summary>
    public class DOService : IDOService
    {
        private readonly AcexGestionContext _context;

        public DOService(AcexGestionContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene un DO por su ID
        /// </summary>
        public async Task<DOControlViewModel> GetDOByIdAsync(int id)
        {
            var doEntity = await _context.DOs
                .FirstOrDefaultAsync(d => d.idDO == id);

            if (doEntity == null)
                return new DOControlViewModel();

            return MapDOToViewModel(doEntity);
        }

        /// <summary>
        /// Obtiene un DO por su número
        /// </summary>
        public async Task<DOControlViewModel> GetDOByNumberAsync(string nroDO)
        {
            var doEntity = await _context.DOs
                .FirstOrDefaultAsync(d => d.NroDO == nroDO && d.tipo == "IMPO");

            if (doEntity == null)
                return new DOControlViewModel();

            return MapDOToViewModel(doEntity);
        }

        /// <summary>
        /// Busca DOs según término de búsqueda
        /// </summary>
        public async Task<List<DOSearchResult>> SearchDOAsync(string searchTerm)
        {
            var query = _context.DOs
                .Where(d => d.tipo == "IMPO");

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(d =>
                    d.NroDO.Contains(searchTerm) ||
                    d.nropedido.Contains(searchTerm) ||
                    d.observaciones.Contains(searchTerm));
            }

            var results = await query
                .Select(d => new DOSearchResult
                {
                    IdDO = d.idDO,
                    NroDO = d.NroDO ?? "Sin número",
                    Exportador = d.idexportador.HasValue ?
                        _context.exportadors.FirstOrDefault(e => e.idexportador == d.idexportador).razonsocial ?? "" : "",
                    Estado = d.estado ?? "Abierto",
                    FechaCreacion = d.FechaCreacion ?? DateTime.Now
                })
                .OrderByDescending(d => d.FechaCreacion)
                .Take(50)
                .ToListAsync();

            return results;
        }

        /// <summary>
        /// Guarda un nuevo DO
        /// </summary>
        public async Task<int> SaveDOAsync(DOControlViewModel model)
        {
            try
            {
                var doEntity = new DO
                {
                    NroDO = string.IsNullOrEmpty(model.NroDO) || model.NroDO == "Sin asignar" ?
                        await GenerateNewDONumberAsync() : model.NroDO,
                    FechaCreacion = DateTime.Now,
                    idexportador = model.IdExportador,
                    idContacto = model.IdContacto,
                    SedeComercializadora = model.SedeComercializadora,
                    ValorMercancia = model.ValorMercancia,
                    SedeOperativa = model.SedeOperativa,
                    nropedido = model.NroPedido,
                    NroCotizacion = model.NroCotizacion,
                    Idincoterm = model.IdIncoterm,
                    TipoMercancia = model.TipoMercancia,
                    peso = model.Peso,
                    dimensiones = model.Dimensiones,
                    TipoDimension = model.TipoDimension,
                    idEmision = model.IdEmision,
                    idPaisOrigen = model.IdPaisOrigen,
                    ciudaOrigen = model.CiudadOrigen,
                    seguro = string.IsNullOrEmpty(model.Seguro) ? (bool?)null : bool.Parse(model.Seguro),
                    idPaisDestino = model.IdPaisDestino,
                    ciudadDestino = model.CiudadDestino,
                    InstruccionesEspeciales = model.InstruccionesEspeciales,
                    idtipocarga = model.IdTipoCarga,                   
                    idNaviera = model.IdNaviera,
                    idAgenteInternacionalOrigen = model.IdAgenteInternacionalOrigen,
                    idAgenteInternacionalDestino = model.IdAgenteInternacionalDestino,
                    observaciones = model.Observaciones,
                    estado = model.Estado,
                    proveedor = model.Proveedor,
                    proveedorShipper = model.ProveedorShipper,
                    DeclaracionAnti = model.DeclaracionAnticipada ? true : false,
                    idPuertoOrigen = model.IdPuertoOrigen,
                    idPuertoDestino = model.IdPuertoDestino,
                    idmodotransporte = model.IdModoTransporte,
                    idmoneda = model.IdMoneda,
                    tasacambio = model.TasaCambio?.ToString(),
                    idmodalidad = model.IdModalidad,
                    factura = model.Factura,
                    merpeligrosa = model.MercPeligrosa,
                    tipo = "IMPO",
                    DocumentoTransporte = model.DocumentoTransporte,
                    IdMonedaValorMercancia = model.IdMonedaValorMercancia

                };

                _context.DOs.Add(doEntity);
                await _context.SaveChangesAsync();

                // Si hay transporte nacional, guardar en ServiciosPorDO
                if (model.TransporteNacional)
                {
                    await SaveTransporteNacionalAsync(doEntity.idDO, model);
                }

                return doEntity.idDO;
            }
            catch (Exception ex)
            {
                // Log del error
                Console.WriteLine($"Error al guardar DO: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Actualiza un DO existente
        /// </summary>
        public async Task<bool> UpdateDOAsync(DOControlViewModel model)
        {
            try
            {
                var doEntity = await _context.DOs.FindAsync(model.IdDO);
                if (doEntity == null)
                    return false;

                // Actualizar campos
                doEntity.idexportador = model.IdExportador;
                doEntity.idContacto = model.IdContacto;
                doEntity.SedeComercializadora = model.SedeComercializadora;
                doEntity.SedeOperativa = model.SedeOperativa;
                doEntity.nropedido = model.NroPedido;
                doEntity.NroCotizacion = model.NroCotizacion;
                doEntity.Idincoterm = model.IdIncoterm;
                doEntity.TipoMercancia = model.TipoMercancia;
                doEntity.peso = model.Peso;
                doEntity.dimensiones = model.Dimensiones;
                doEntity.TipoDimension = model.TipoDimension;
                doEntity.idEmision = model.IdEmision;
                doEntity.idPaisOrigen = model.IdPaisOrigen;
                doEntity.ciudaOrigen = model.CiudadOrigen;
                doEntity.idPaisDestino = model.IdPaisDestino;
                doEntity.ciudadDestino = model.CiudadDestino;
                doEntity.InstruccionesEspeciales = model.InstruccionesEspeciales;
                doEntity.idtipocarga = model.IdTipoCarga;
                doEntity.seguro = string.IsNullOrEmpty(model.Seguro) ? (bool?)null : bool.Parse(model.Seguro);
                doEntity.idNaviera = model.IdNaviera;
                doEntity.idAgenteInternacionalOrigen = model.IdAgenteInternacionalOrigen;
                doEntity.idAgenteInternacionalDestino = model.IdAgenteInternacionalDestino;
                doEntity.observaciones = model.Observaciones;
                doEntity.proveedor = model.Proveedor;
                doEntity.proveedorShipper = model.ProveedorShipper;
                doEntity.DeclaracionAnti = model.DeclaracionAnticipada ? true : false;
                doEntity.idPuertoOrigen = model.IdPuertoOrigen;
                doEntity.idPuertoDestino = model.IdPuertoDestino;
                doEntity.DocumentoTransporte = model.DocumentoTransporte;
                doEntity.ValorMercancia = model.ValorMercancia;
                doEntity.IdMonedaValorMercancia = model.IdMonedaValorMercancia;


                await _context.SaveChangesAsync();

                // Actualizar transporte nacional si aplica
                if (model.TransporteNacional)
                {
                    await SaveTransporteNacionalAsync(model.IdDO, model);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar DO: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Cierra un DO
        /// </summary>
        public async Task<bool> CloseDOAsync(int idDO, string estado)
        {
            try
            {
                var doEntity = await _context.DOs.FindAsync(idDO);
                if (doEntity == null)
                    return false;

                doEntity.estado = estado;
                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Duplica un DO
        /// </summary>
        public async Task<bool> DuplicateDOAsync(int idDO)
        {
            try
            {
                var original = await _context.DOs.FindAsync(idDO);
                if (original == null)
                    return false;

                var duplicado = new DO
                {
                    NroDO = original.NroDO + "_COPIA_" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    FechaCreacion = DateTime.Now,
                    idexportador = original.idexportador,
                    idContacto = original.idContacto,
                    SedeComercializadora = original.SedeComercializadora,
                    SedeOperativa = original.SedeOperativa,
                    nropedido = original.nropedido,
                    NroCotizacion = original.NroCotizacion,
                    Idincoterm = original.Idincoterm,
                    TipoMercancia = original.TipoMercancia,
                    peso = original.peso,
                    dimensiones = original.dimensiones,
                    TipoDimension = original.TipoDimension,
                    idEmision = original.idEmision,
                    idPaisOrigen = original.idPaisOrigen,
                    ciudaOrigen = original.ciudaOrigen,
                    idPaisDestino = original.idPaisDestino,
                    ciudadDestino = original.ciudadDestino,
                    InstruccionesEspeciales = original.InstruccionesEspeciales,
                    idtipocarga = original.idtipocarga,
                    seguro = original.seguro,
                    idNaviera = original.idNaviera,
                    idAgenteInternacionalOrigen = original.idAgenteInternacionalOrigen,
                    idAgenteInternacionalDestino = original.idAgenteInternacionalDestino,
                    observaciones = original.observaciones,
                    estado = "Abierto",
                    tipo = original.tipo
                };

                _context.DOs.Add(duplicado);
                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Genera un nuevo número de DO
        /// </summary>
        public async Task<string> GenerateNewDONumberAsync()
        {
            var year = DateTime.Now.Year.ToString();
            var lastDO = await _context.DOs
                .Where(d => d.NroDO.StartsWith("DO" + year))
                .OrderByDescending(d => d.NroDO)
                .FirstOrDefaultAsync();

            int nextNumber = 1;
            if (lastDO != null && !string.IsNullOrEmpty(lastDO.NroDO))
            {
                var lastNumber = lastDO.NroDO.Replace("DO" + year, "");
                if (int.TryParse(lastNumber, out int parsed))
                {
                    nextNumber = parsed + 1;
                }
            }

            return $"DO{year}{nextNumber:D6}";
        }

        /// <summary>
        /// Verifica si un DO está duplicado
        /// </summary>
        public async Task<bool> CheckDuplicateDOAsync(string nroDO)
        {
            var count = await _context.DOs
                .CountAsync(d => d.NroDO.StartsWith(nroDO));

            return count > 2;
        }

        /// <summary>
        /// Mapea entidad DO a ViewModel
        /// </summary>
        private DOControlViewModel MapDOToViewModel(DO doEntity)
        {
            return new DOControlViewModel
            {
                IdDO = doEntity.idDO,
                NroDO = doEntity.NroDO ?? "Sin asignar",
                FechaCreacion = doEntity.FechaCreacion ?? DateTime.Now,
                SedeComercializadora = doEntity.SedeComercializadora,
                SedeOperativa = doEntity.SedeOperativa,
                ProveedorShipper = doEntity.proveedorShipper,
                IdExportador = doEntity.idexportador,
                IdContacto = doEntity.idContacto,
                NroPedido = doEntity.nropedido,
                NroCotizacion = doEntity.NroCotizacion,
                IdIncoterm = doEntity.Idincoterm,
                TipoMercancia = doEntity.TipoMercancia,
                Peso = doEntity.peso,
                Dimensiones = doEntity.dimensiones,
                TipoDimension = doEntity.TipoDimension,
                IdEmision = doEntity.idEmision,
                IdPaisOrigen = doEntity.idPaisOrigen,
                CiudadOrigen = doEntity.ciudaOrigen,
                IdPaisDestino = doEntity.idPaisDestino,
                CiudadDestino = doEntity.ciudadDestino,
                InstruccionesEspeciales = doEntity.InstruccionesEspeciales,
                IdTipoCarga = doEntity.idtipocarga,
                Seguro = "",            
                IdNaviera = doEntity.idNaviera,
                IdAgenteInternacionalOrigen = doEntity.idAgenteInternacionalOrigen,
                IdAgenteInternacionalDestino = doEntity.idAgenteInternacionalDestino,
                Observaciones = doEntity.observaciones,
                Estado = doEntity.estado ?? "Abierto",
                Proveedor = doEntity.proveedor,
                DeclaracionAnticipada = doEntity.DeclaracionAnti == true,
                IdPuertoOrigen = doEntity.idPuertoOrigen,
                IdPuertoDestino = doEntity.idPuertoDestino,
                IdModoTransporte = doEntity.idmodotransporte,
                IdMoneda = doEntity.idmoneda,
                TasaCambio = decimal.TryParse(doEntity.tasacambio, out var tasa) ? tasa : null,
                IdModalidad = doEntity.idmodalidad,
                Factura = doEntity.factura,
                MercPeligrosa = doEntity.merpeligrosa ?? false,
                ValorMercancia = doEntity.ValorMercancia,
                DocumentoTransporte = doEntity.DocumentoTransporte,
                IdMonedaValorMercancia = doEntity.IdMonedaValorMercancia

            };
        }

        /// <summary>
        /// Guarda información de transporte nacional
        /// </summary>
        private async Task SaveTransporteNacionalAsync(int idDO, DOControlViewModel model)
        {
            // Aquí implementarías la lógica para guardar en ServiciosPorDO
            // Por ahora es un placeholder
            await Task.CompletedTask;
        }
    }
}