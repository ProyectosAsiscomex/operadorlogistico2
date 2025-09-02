using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class CuentasxPagar_Abiertum
{
    public DateOnly? fecha { get; set; }

    public DateOnly? vence { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    public int? plazo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nrofactura { get; set; }

    [StringLength(100)]
    public string? tercero { get; set; }

    [StringLength(20)]
    public string? nit { get; set; }

    public int? Sede { get; set; }

    [Column(TypeName = "decimal(32, 4)")]
    public decimal? valorbruto { get; set; }

    [Column(TypeName = "decimal(32, 4)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteFuente { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? retecree { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? descuentos { get; set; }

    [Column(TypeName = "decimal(34, 4)")]
    public decimal? valorneto { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string tipodoc { get; set; } = null!;

    [StringLength(100)]
    public string? Moneda { get; set; }

    public int idcausacion { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasa { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? trm { get; set; }
}
