using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ControlCargasImportacion")]
public partial class ControlCargasImportacion
{
    [Key]
    public int idcontrolcargasimportacion { get; set; }

    public int? idcompania { get; set; }

    public int? idpedido { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? factura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechapagofactura { get; set; }

    public int? idnaviera { get; set; }

    public int? idembarcador { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? acuerdo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? peligrosa { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantsobordada { get; set; }

    public int? idunidad { get; set; }

    public int? idtipocarga { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobrutoindicadorbultos { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? volumen { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fletes { get; set; }

    [Column(TypeName = "money")]
    public decimal? inland { get; set; }

    [Column(TypeName = "money")]
    public decimal? recargos { get; set; }

    [Column(TypeName = "money")]
    public decimal? fletealcobro { get; set; }

    [Column(TypeName = "money")]
    public decimal? fleteprepago { get; set; }

    [Column(TypeName = "money")]
    public decimal? fletetotal { get; set; }

    public int? idtamanocontenedor { get; set; }

    public int? idtipoequipo { get; set; }

    public bool? modoflete { get; set; }
}
