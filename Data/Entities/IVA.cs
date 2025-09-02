using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("IVA")]
public partial class IVA
{
    [Key]
    public int idIVA { get; set; }

    [StringLength(15)]
    public string? posicion { get; set; }

    [StringLength(300)]
    public string? Tarifa { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Desde { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Hasta { get; set; }

    [StringLength(300)]
    public string? Legislacion { get; set; }

    [StringLength(500)]
    public string? ArchivoLegislacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaUltimaActualizacion { get; set; }

    public string? Observaciones { get; set; }

    [StringLength(200)]
    public string? tipo { get; set; }

    public int? idivaColombia { get; set; }
}
