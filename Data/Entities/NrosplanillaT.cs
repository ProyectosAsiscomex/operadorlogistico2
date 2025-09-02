using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("NrosplanillaT")]
public partial class NrosplanillaT
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string nroformularioreservado { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? estado { get; set; }
}
