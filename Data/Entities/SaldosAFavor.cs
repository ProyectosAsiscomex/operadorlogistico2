using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SaldosAFavor")]
public partial class SaldosAFavor
{
    [Key]
    public int idsaldoafavor { get; set; }

    public int? idcliente { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechayhora { get; set; }

    public int? idusuario { get; set; }

    public int? idtercero { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorterceros { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorpropios { get; set; }

    [Column(TypeName = "money")]
    public decimal? iva { get; set; }

    [Column(TypeName = "money")]
    public decimal? anticipo { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorbruto { get; set; }

    [Column(TypeName = "money")]
    public decimal? retefuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorneto { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorabonado { get; set; }

    [Column(TypeName = "money")]
    public decimal? saldo { get; set; }

    [Unicode(false)]
    public string? observaciones { get; set; }

    public bool? anulado { get; set; }

    public int? iddo { get; set; }

    public int? idfactura { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Naturaleza { get; set; }

    public bool? anular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroNotaCredito { get; set; }

    public bool? Excluir { get; set; }

    public bool? sincronizada { get; set; }
}
