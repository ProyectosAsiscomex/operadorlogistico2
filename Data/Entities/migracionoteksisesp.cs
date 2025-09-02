using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("migracionoteksisesp")]
public partial class migracionoteksisesp
{
    [StringLength(500)]
    public string? programa { get; set; }

    [StringLength(500)]
    public string? cip { get; set; }

    [StringLength(500)]
    public string? cipdesc { get; set; }

    [StringLength(500)]
    public string? partida { get; set; }

    [StringLength(100)]
    public string? unidad { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? precioxcip { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? van { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? vie { get; set; }
}
