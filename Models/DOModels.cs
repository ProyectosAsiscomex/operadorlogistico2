using System;
using System.ComponentModel.DataAnnotations;

namespace AsiscomexOperadorLogistico.Models
{
    /// <summary>
    /// Modelo de vista para el formulario de control de DO (Documento de Operación)
    /// </summary>
    public class DOControlViewModel
    {
        public int IdDO { get; set; }

        [Display(Name = "Número de DO")]
        public string NroDO { get; set; } = "Sin asignar";

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Display(Name = "Sede Comercializadora")]
        public int? SedeComercializadora { get; set; }

        [Display(Name = "Sede Operativa")]
        public int? SedeOperativa { get; set; }

        [Display(Name = "Proveedor/Shipper")]
        public string? ProveedorShipper { get; set; }

        [Display(Name = "Exportador")]
        public int? IdExportador { get; set; }

        [Display(Name = "Contacto")]
        public int? IdContacto { get; set; }

        [Display(Name = "Número de Pedido")]
        public string? NroPedido { get; set; }

        [Display(Name = "Número de Cotización")]
        public string? NroCotizacion { get; set; }

        [Display(Name = "Incoterm")]
        public int? IdIncoterm { get; set; }

        [Display(Name = "Tipo de Mercancía")]
        public string? TipoMercancia { get; set; }

        [Display(Name = "Peso")]
        public decimal? Peso { get; set; }

        [Display(Name = "Dimensiones")]
        public decimal? Dimensiones { get; set; }

        [Display(Name = "Tipo de Dimensión")]
        public string? TipoDimension { get; set; }

        [Display(Name = "Emisión")]
        public string? IdEmision { get; set; }

        [Display(Name = "País de Origen")]
        public int? IdPaisOrigen { get; set; }

        [Display(Name = "Ciudad de Origen")]
        public string? CiudadOrigen { get; set; }

        [Display(Name = "País de Destino")]
        public int? IdPaisDestino { get; set; }

        [Display(Name = "Ciudad de Destino")]
        public string? CiudadDestino { get; set; }

        [Display(Name = "Instrucciones Especiales")]
        public string? InstruccionesEspeciales { get; set; }

        [Display(Name = "Tipo de Carga")]
        public int? IdTipoCarga { get; set; }

        [Display(Name = "Seguro")]
        public string? Seguro { get; set; }

        [Display(Name = "Naviera")]
        public int? IdNaviera { get; set; }

        [Display(Name = "Agente Internacional Origen")]
        public int? IdAgenteInternacionalOrigen { get; set; }

        [Display(Name = "Agente Internacional Destino")]
        public int? IdAgenteInternacionalDestino { get; set; }

        [Display(Name = "Observaciones")]
        public string? Observaciones { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Abierto";

        [Display(Name = "Proveedor")]
        public string? Proveedor { get; set; }

        [Display(Name = "Declaración Anticipada")]
        public bool DeclaracionAnticipada { get; set; }

        [Display(Name = "Puerto de Origen")]
        public int? IdPuertoOrigen { get; set; }

        [Display(Name = "Puerto de Destino")]
        public int? IdPuertoDestino { get; set; }

        // Campos de Transporte Nacional
        public bool TransporteNacional { get; set; }
        public DateTime? FechaSolicitudTN { get; set; }
        public DateTime? FechaDeCargueTN { get; set; }
        public DateTime? FechaCargueProductoTN { get; set; }
        public decimal? ValorTN { get; set; }
        public string? VehiculoTN { get; set; }
        public decimal? FleteTN { get; set; }
        public string? CargueyDescargueTN { get; set; }
        public decimal? ValorMercancia { get; set; }
        public string? DireccionOrigen { get; set; }
        public int? IdPuertoRetiro { get; set; }
        public string? DireccionDestino { get; set; }
        public string? DireccionDevolucionContenedor { get; set; }
        public int? Cantidad { get; set; }
        public string? Cabotaje { get; set; }

        // Otros campos
        public int? IdModoTransporte { get; set; }
        public int? IdMoneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public int? IdModalidad { get; set; }
        public string? Factura { get; set; }
        public bool MercPeligrosa { get; set; }

        // Campos de documentos
        public int? IdTipoDocumento { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public DateTime? FechaVigencia { get; set; }

        // Campos de cierre
        public DateTime? FechaCierre { get; set; }
        public DateTime? FechaZarpe { get; set; }
        public DateTime? FechaArribo { get; set; }

        // Navegación
        public string Tipo { get; set; } = "IMPO";

        public string? DocumentoTransporte { get; set; }

        [Display(Name = "Moneda Mercancía")]
        public int? IdMonedaValorMercancia { get; set; }

    }

    /// <summary>
    /// Clase para manejar opciones de combos/selects
    /// </summary>
    public class SelectOption
    {
        public string Value { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }

    /// <summary>
    /// Modelo para el resultado de búsqueda de DO
    /// </summary>
    public class DOSearchResult
    {
        public int IdDO { get; set; }
        public string NroDO { get; set; } = string.Empty;
        public string Exportador { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
    }
}