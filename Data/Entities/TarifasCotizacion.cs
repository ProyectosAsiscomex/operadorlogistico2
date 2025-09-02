using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TarifasCotizacion")]
public partial class TarifasCotizacion
{
    [Key]
    public int Id { get; set; }

    public int? CotizacionId { get; set; }

    public int? ConceptoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? Tarifa { get; set; }

    [Column(TypeName = "money")]
    public decimal? Liquidacion { get; set; }

    public int? MonedaTarifaId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TarifaMinima { get; set; }

    [Unicode(false)]
    public string? Porcentaje { get; set; }

    public int? UnidadId { get; set; }

    public int? DetalleMercanciasCotizacionId { get; set; }

    [StringLength(200)]
    public string? Comment { get; set; }

    public int? tamanoContenedorId { get; set; }

    [Unicode(false)]
    public string? TipoGasto { get; set; }

    [Unicode(false)]
    public string? RutaContenedor { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }

    public int? IdPuertoOrigen { get; set; }

    public int? IdPuertoDestino { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PesoCargable { get; set; }

    [Column(TypeName = "money")]
    public decimal? TarifaCompra { get; set; }

    public int IdDO { get; set; }

    public bool HabilitadoFact { get; set; }

    public bool ItemFacturado { get; set; }

    [ForeignKey("CotizacionId")]
    [InverseProperty("TarifasCotizacions")]
    public virtual Cotizacione? Cotizacion { get; set; }
}
