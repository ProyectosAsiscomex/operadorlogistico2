using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Gravamene
{
    [Key]
    public int idGravamen { get; set; }

    [StringLength(15)]
    public string? posicion { get; set; }

    [StringLength(200)]
    public string? Concepto { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Tarifa { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Desde { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Hasta { get; set; }

    [StringLength(500)]
    public string? Legislacion { get; set; }

    [StringLength(300)]
    public string? Origen { get; set; }

    [StringLength(1000)]
    public string? ArchivoLegislacion { get; set; }

    [StringLength(2000)]
    public string? observaciones { get; set; }

    [StringLength(200)]
    public string? tipo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadecaptura { get; set; }

    public int? idGravamenColombia { get; set; }
}
