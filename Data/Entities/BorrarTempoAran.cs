using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("BorrarTempoAran")]
public partial class BorrarTempoAran
{
    [StringLength(10)]
    public string? posicion { get; set; }

    public string? desmin { get; set; }

    public string? desaran { get; set; }

    [StringLength(10)]
    public string? codregimpo { get; set; }

    [StringLength(10)]
    public string? estado { get; set; }

    [StringLength(10)]
    public string? reqdesc { get; set; }

    [Column(TypeName = "decimal(30, 10)")]
    public decimal? arancel { get; set; }

    [Column(TypeName = "decimal(30, 10)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "decimal(30, 10)")]
    public decimal? porotro { get; set; }

    [Column(TypeName = "decimal(30, 10)")]
    public decimal? reqri { get; set; }
}
