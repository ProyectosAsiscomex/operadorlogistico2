using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ColumnasExportacion")]
public partial class ColumnasExportacion
{
    [Key]
    public int idcolumnasexportacion { get; set; }

    [StringLength(200)]
    public string? texto { get; set; }

    [StringLength(200)]
    public string? valor { get; set; }

    [StringLength(200)]
    public string? nombrefiltro { get; set; }

    [StringLength(200)]
    public string? nombreformulario { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }
}
