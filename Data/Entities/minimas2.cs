using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("minimas2")]
public partial class minimas2
{
    [Key]
    public int idMinima2 { get; set; }

    public int? idminima1 { get; set; }

    [StringLength(500)]
    public string? valorminima1 { get; set; }

    [StringLength(500)]
    public string? valorminima2 { get; set; }

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
