using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Novedad")]
public partial class Novedad
{
    [Key]
    public int idNovedad { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Titulo { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? Texto { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Imagen { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaExpira { get; set; }

    public bool? faq { get; set; }
}
