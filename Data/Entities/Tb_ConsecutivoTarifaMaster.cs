using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Tb_ConsecutivoTarifaMaster")]
public partial class Tb_ConsecutivoTarifaMaster
{
    [Key]
    public int id { get; set; }

    public int? IdTarifaMaster { get; set; }

    public int? consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }
}
