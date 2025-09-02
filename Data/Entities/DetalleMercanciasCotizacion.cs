using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleMercanciasCotizacion")]
public partial class DetalleMercanciasCotizacion
{
    [Key]
    public int Id { get; set; }

    public int? CotizacionId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Dimenciones { get; set; }

    public int? Cantidad { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? Peso { get; set; }

    public int? NumeroContenedores { get; set; }

    public int? DiasLibres { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Descripción { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TipoContenedor { get; set; }

    public int? TamanioContenedorId { get; set; }

    public int? IdTarifarioItem { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? PesoBruto { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? CantidadCaja { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? Unidades { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? ValorMercancia { get; set; }

    public int? MonedaValorMercanciaId { get; set; }

    public int? TipoCargaId { get; set; }

    [ForeignKey("CotizacionId")]
    [InverseProperty("DetalleMercanciasCotizacions")]
    public virtual Cotizacione? Cotizacion { get; set; }
}
