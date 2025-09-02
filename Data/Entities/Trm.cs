using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Trm")]
public partial class Trm
{
    [Key]
    public int idtrm { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? valor { get; set; }

    public bool? estado { get; set; }

    public int? idmonedabase { get; set; }

    public int? idmonedareferencia { get; set; }

    public int? semana { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafinal { get; set; }

    public bool? principal { get; set; }
}
