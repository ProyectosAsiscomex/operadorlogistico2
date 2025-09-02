using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("IndicadoresExportacion")]
public partial class IndicadoresExportacion
{
    [Key]
    public int idIndicador { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombreIndicador { get; set; }
}
