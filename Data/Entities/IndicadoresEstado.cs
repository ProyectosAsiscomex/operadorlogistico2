using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("IndicadoresEstado")]
public partial class IndicadoresEstado
{
    [Key]
    public int idIndicadoresEstado { get; set; }

    public int? idIndicador { get; set; }

    public int? idEstado { get; set; }

    public int? idEstadoComparacion { get; set; }

    public int? posicion { get; set; }

    public int? dias { get; set; }

    [StringLength(300)]
    public string? Medicion { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? valorxdia { get; set; }
}
