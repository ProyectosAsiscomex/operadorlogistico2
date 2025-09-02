using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TempoKit")]
public partial class TempoKit
{
    [StringLength(255)]
    public string? tipo { get; set; }

    [StringLength(255)]
    public string? prefijo { get; set; }

    [StringLength(255)]
    public string? d_o { get; set; }

    [StringLength(255)]
    public string? marca { get; set; }

    public double? numero { get; set; }
}
