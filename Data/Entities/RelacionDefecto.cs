using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RelacionDefecto")]
public partial class RelacionDefecto
{
    [Key]
    public int idrelaciondefecto { get; set; }

    [StringLength(200)]
    public string? tabla { get; set; }

    [StringLength(200)]
    public string? aliastabla { get; set; }

    [StringLength(200)]
    public string? campo { get; set; }

    [StringLength(200)]
    public string? aliascampo { get; set; }

    public int idtabladetalleinformedinamico { get; set; }

    [StringLength(200)]
    public string? camporetorno { get; set; }

    [StringLength(200)]
    public string? aliascamporetorno { get; set; }
}
