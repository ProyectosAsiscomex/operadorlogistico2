using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TempoProvee")]
public partial class TempoProvee
{
    public int? idimportador { get; set; }

    public int? idexportador { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? indicador { get; set; }
}
