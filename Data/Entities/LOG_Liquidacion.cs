using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LOG_Liquidacion")]
public partial class LOG_Liquidacion
{
    [Key]
    public int idliquidacionlog { get; set; }

    public int? iddo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public int? idusuario { get; set; }

    [StringLength(200)]
    public string? tipo { get; set; }
}
