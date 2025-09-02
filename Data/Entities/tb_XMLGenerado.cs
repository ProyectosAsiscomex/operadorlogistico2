using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class tb_XMLGenerado
{
    [Key]
    public int id { get; set; }

    [StringLength(500)]
    public string? ruta { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCreacion { get; set; }

    public int? iduduario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaTraslado { get; set; }

    public bool? trasladado { get; set; }
}
