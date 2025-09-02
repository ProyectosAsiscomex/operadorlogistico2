using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class ListadoFactura
{
    public int idfactura { get; set; }

    [StringLength(50)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fechavence { get; set; }

    [StringLength(653)]
    [Unicode(false)]
    public string? cliente { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NIT { get; set; }

    [StringLength(20)]
    public string? TELEFONO { get; set; }

    [StringLength(40)]
    public string? CIUDAD { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal terceros { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal propios { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? iva16 { get; set; }

    [Column(TypeName = "money")]
    public decimal? anticipos { get; set; }

    [Column(TypeName = "money")]
    public decimal Abonos { get; set; }

    [Column(TypeName = "decimal(38, 10)")]
    public decimal valorfactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? retefuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? valorneto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    public long? sindo { get; set; }

    [StringLength(20)]
    public string? usuario { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string estado { get; set; } = null!;

    public int? idcliente { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? RETEF { get; set; }

    [Column(TypeName = "money")]
    public decimal Reteica { get; set; }

    [Column(TypeName = "money")]
    public decimal NotasAplicadas { get; set; }
}
