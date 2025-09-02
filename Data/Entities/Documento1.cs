using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Documento1
{
    [Key]
    public int iddocumento { get; set; }

    [StringLength(100)]
    public string? nombre { get; set; }

    public bool? obligatorio { get; set; }

    [Column(TypeName = "money")]
    public decimal? costo { get; set; }
}
