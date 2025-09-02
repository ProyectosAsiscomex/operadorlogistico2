using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("CipExpo")]
public partial class CipExpo
{
    public double? tcode { get; set; }

    public double? tcodi { get; set; }

    [StringLength(255)]
    public string? tnomb { get; set; }

    public double? tvan { get; set; }

    public double? tval_fob { get; set; }

    public double? tpeso { get; set; }
}
