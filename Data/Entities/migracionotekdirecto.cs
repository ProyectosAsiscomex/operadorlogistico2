using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class migracionotekdirecto
{
    [StringLength(500)]
    public string? cip { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? van { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? vie { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? vrfobcip { get; set; }
}
