using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EstructuraWS")]
public partial class EstructuraW
{
    [Key]
    public int idws { get; set; }

    [StringLength(50)]
    public string? nombre { get; set; }

    [StringLength(50)]
    public string? campo { get; set; }

    [StringLength(5)]
    public string? Tamaño { get; set; }

    public bool? obligatorio { get; set; }

    public bool? usardefecto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tipo { get; set; }
}
