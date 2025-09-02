using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Cotizacione
{
    [Key]
    public int Id { get; set; }

    public int? ComercialId { get; set; }

    public int? ModenaId { get; set; }

    public int? ExportadorId { get; set; }

    public int? TipoOperacionId { get; set; }

    public int? SucursalId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FrecuenciaType { get; set; }

    public int? IncotermId { get; set; }

    public int? Estado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCotizacion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Origen { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Destino { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? TiempoTransito { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime InicioVigencia { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime FinalVigencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Servicio { get; set; }

    public string? ObservacionesGenerales { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CondicionesEspeciales { get; set; }

    public int? ContactId { get; set; }

    [Unicode(false)]
    public string? LiberacionAutomatica { get; set; }

    [Unicode(false)]
    public string? ExoneracionDeposito { get; set; }

    [Unicode(false)]
    public string? ExoneracionDropoff { get; set; }

    [Unicode(false)]
    public string? DropoffSujeto { get; set; }

    public int? FormaPagoId { get; set; }

    [Unicode(false)]
    public string? Transbordo { get; set; }

    public int? IdTarifario { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tasa { get; set; }

    [StringLength(100)]
    public string? TipoMercancia { get; set; }

    [Unicode(false)]
    public string? Pedido { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Porcentaje { get; set; }

    [Unicode(false)]
    public string? TipoPorcentaje { get; set; }

    [ForeignKey("ComercialId")]
    [InverseProperty("Cotizaciones")]
    public virtual usuario? Comercial { get; set; }

    [InverseProperty("Cotizacion")]
    public virtual ICollection<DetalleMercanciasCotizacion> DetalleMercanciasCotizacions { get; set; } = new List<DetalleMercanciasCotizacion>();

    [ForeignKey("Estado")]
    [InverseProperty("Cotizaciones")]
    public virtual EstadoCotizacion? EstadoNavigation { get; set; }

    [ForeignKey("ExportadorId")]
    [InverseProperty("Cotizaciones")]
    public virtual exportador? Exportador { get; set; }

    [ForeignKey("IncotermId")]
    [InverseProperty("Cotizaciones")]
    public virtual incoterm? Incoterm { get; set; }

    [InverseProperty("Cotizacion")]
    public virtual ICollection<MedidasCotizacion> MedidasCotizacions { get; set; } = new List<MedidasCotizacion>();

    [ForeignKey("ModenaId")]
    [InverseProperty("Cotizaciones")]
    public virtual moneda? Modena { get; set; }

    [InverseProperty("Cotizacion")]
    public virtual ICollection<TarifasCotizacion> TarifasCotizacions { get; set; } = new List<TarifasCotizacion>();

    [ForeignKey("TipoOperacionId")]
    [InverseProperty("Cotizaciones")]
    public virtual tipodeoperacion? TipoOperacion { get; set; }
}
