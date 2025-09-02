using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ControlDeposito")]
public partial class ControlDeposito
{
    [Key]
    public int idcontroldeposito { get; set; }

    public int? idcompania { get; set; }

    public int? idorden { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nrodocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public short? idtercero { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valordeposito { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? reintegrado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechareintegro { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? saldofavor { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? saldocontra { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrocontenedor { get; set; }
}
