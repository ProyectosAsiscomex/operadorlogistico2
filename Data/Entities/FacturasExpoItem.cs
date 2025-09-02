using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturasExpoItem")]
public partial class FacturasExpoItem
{
    [Key]
    public int idfacturaexpoitem { get; set; }

    public int? idfacturaexpo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cip { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? valorunitario { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? pordesc { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? pesobruto { get; set; }

    public int? item { get; set; }

    public int? idproducto { get; set; }
}
