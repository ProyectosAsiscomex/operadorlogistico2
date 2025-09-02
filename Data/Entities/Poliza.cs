using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Poliza
{
    [Key]
    public int idPoliza { get; set; }

    public int? idExportador { get; set; }

    [StringLength(300)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? valor { get; set; }

    public bool? activo { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }
}
