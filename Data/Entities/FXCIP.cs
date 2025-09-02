using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("FXCIP")]
public partial class FXCIP
{
    [StringLength(50)]
    public string? CIP { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? VALFOB { get; set; }
}
