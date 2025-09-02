using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EstructuraWSIR")]
public partial class EstructuraWSIR
{
    [Key]
    public int idestructuraWSRI { get; set; }

    public int? idWS { get; set; }

    [StringLength(250)]
    public string? tabla { get; set; }

    [StringLength(250)]
    public string? campo { get; set; }
}
