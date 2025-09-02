using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("minimas1")]
public partial class minimas1
{
    [Key]
    public int idminima1 { get; set; }

    public int? iddescripcion { get; set; }

    [StringLength(500)]
    public string? descripcion { get; set; }

    [StringLength(500)]
    public string? valorminima1 { get; set; }

    public int? orden { get; set; }

    public int? codigo { get; set; }

    [StringLength(100)]
    public string? tipodato { get; set; }

    public int? longitud { get; set; }

    [StringLength(50)]
    public string? obligatorio { get; set; }

    [StringLength(50)]
    public string? detalle { get; set; }
}
