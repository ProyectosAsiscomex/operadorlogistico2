using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("LeoConsecutivo")]
public partial class LeoConsecutivo
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public int? cons { get; set; }

    public int? iddo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? pedido { get; set; }
}
