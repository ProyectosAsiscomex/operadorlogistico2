using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SegmentosEDIFAC")]
public partial class SegmentosEDIFAC
{
    [Key]
    public int idSegmento { get; set; }

    [StringLength(500)]
    public string? NombreSegmento { get; set; }

    [StringLength(500)]
    public string? Nomenclatura { get; set; }

    public bool? Obligatorio { get; set; }

    [StringLength(2)]
    public string? tipo { get; set; }

    public int? longitud { get; set; }

    public int? decimales { get; set; }
}
