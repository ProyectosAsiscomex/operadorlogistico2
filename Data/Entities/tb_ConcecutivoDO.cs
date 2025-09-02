using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_ConcecutivoDO")]
public partial class tb_ConcecutivoDO
{
    [Key]
    public int idConcecutivo { get; set; }

    public int? idlugaringresomercancias { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? concecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }
}
