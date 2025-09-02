using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("declaracionesitem")]
public partial class declaracionesitem
{
    [Key]
    public int iddetalle { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? auxiliar { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorunit { get; set; }

    public int? iddeclaracion { get; set; }
}
