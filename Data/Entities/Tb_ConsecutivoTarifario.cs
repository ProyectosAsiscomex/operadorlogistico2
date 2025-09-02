using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Tb_ConsecutivoTarifario")]
public partial class Tb_ConsecutivoTarifario
{
    [Key]
    public int Id { get; set; }

    public int? IdTarifario { get; set; }

    public int? Consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }
}
