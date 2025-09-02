using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("eu")]
public partial class eu
{
    [Key]
    public int ideu { get; set; }

    public int? iddocumento { get; set; }

    [StringLength(10)]
    public string? idestado { get; set; }

    [Column(TypeName = "money")]
    public decimal? costo { get; set; }

    public bool? obligatorio { get; set; }
}
