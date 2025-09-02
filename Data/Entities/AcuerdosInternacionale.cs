using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AcuerdosInternacionale
{
    [Key]
    public int idAcuerdo { get; set; }

    [StringLength(15)]
    public string? posicion { get; set; }

    [StringLength(50)]
    public string? tipo { get; set; }

    [StringLength(1000)]
    public string? Acuerdo { get; set; }

    [StringLength(200)]
    public string? pais { get; set; }

    [StringLength(1000)]
    public string? concepto { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? gravamen { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? indice { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasapid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? desde { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? hasta { get; set; }

    [StringLength(300)]
    public string? legislacion { get; set; }

    [StringLength(500)]
    public string? archivolegislacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaultimaactualizacion { get; set; }

    public string? observaciones { get; set; }

    public int? idAcuerdoColombia { get; set; }
}
