using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RutasNombreDO")]
public partial class RutasNombreDO
{
    [Key]
    public int id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? rutanombrearchivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }
}
