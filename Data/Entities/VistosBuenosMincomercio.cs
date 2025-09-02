using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("VistosBuenosMincomercio")]
public partial class VistosBuenosMincomercio
{
    [Key]
    public int idVistoBueno { get; set; }

    [StringLength(50)]
    public string? Posicion { get; set; }

    [StringLength(400)]
    public string? Entidad { get; set; }

    [StringLength(100)]
    public string? Control { get; set; }

    public string? DescripcionControl { get; set; }

    [StringLength(500)]
    public string? TipoNorma { get; set; }

    [StringLength(500)]
    public string? EntidadControl { get; set; }

    [StringLength(50)]
    public string? Numero { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaExpedicion { get; set; }

    [StringLength(50)]
    public string? DiarioOficial { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaPublicacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VigenciaDesde { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VIgenciaHasta { get; set; }

    [StringLength(4000)]
    public string? NotasMarginales { get; set; }

    public int? idvistobuenoColombia { get; set; }
}
