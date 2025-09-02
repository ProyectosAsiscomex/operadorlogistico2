using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RelacionFormulario")]
public partial class RelacionFormulario
{
    [Key]
    public int idrelacionformulario { get; set; }

    [StringLength(500)]
    public string? formulario { get; set; }

    [StringLength(50)]
    public string? parametro { get; set; }

    [StringLength(50)]
    public string? tabla { get; set; }

    [StringLength(50)]
    public string? campovalor { get; set; }

    public int idtabladetalleinformedinamico { get; set; }
}
