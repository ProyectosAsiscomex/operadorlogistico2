using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ControlDepositoDetalle")]
public partial class ControlDepositoDetalle
{
    [Key]
    public int idcontroldepositodetalle { get; set; }

    public int? idcontroldeposito { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nrodocumento { get; set; }

    public int? idtercero { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorfactura { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? concepto { get; set; }
}
