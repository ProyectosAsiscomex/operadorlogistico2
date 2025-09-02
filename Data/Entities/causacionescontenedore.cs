using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class causacionescontenedore
{
    [Key]
    public int idcausacioncontenedor { get; set; }

    public int? idcausacionencabezado { get; set; }

    [StringLength(50)]
    public string? cont20 { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorcont20 { get; set; }

    [StringLength(50)]
    public string? cont40 { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorcont40 { get; set; }
}
