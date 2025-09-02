using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_ConsecutivoDTA")]
public partial class tb_ConsecutivoDTum
{
    [Key]
    public int concecutivo { get; set; }

    public int? idDeclarante { get; set; }

    public int? idAduanas { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NroConcecutivo { get; set; }
}
