using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturaExpoItem")]
public partial class FacturaExpoItem
{
    [Key]
    public int idfacturaexpoitem { get; set; }

    public int? idfacturaexpo { get; set; }

    public int? idproducto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? valorunitario { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? porDescuento { get; set; }

    public int? idunidad { get; set; }

    [StringLength(50)]
    public string? cip { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesoneto { get; set; }

    [StringLength(300)]
    public string? empaque { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidad { get; set; }

    public int? item { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesobruto { get; set; }

    public int? idsubpartida { get; set; }

    [Column(TypeName = "decimal(30, 5)")]
    public decimal? subtotal { get; set; }

    public bool? muestras { get; set; }
}
