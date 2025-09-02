using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturasExpo")]
public partial class FacturasExpo
{
    [Key]
    public int idfacturaexpo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? auxiliar { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? factura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ffactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fvencimiento { get; set; }

    public int? idimportador { get; set; }

    public int? idcomprador { get; set; }

    public int? idmoneda { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? trm { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? flete { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(25, 5)")]
    public decimal? pesobruto { get; set; }

    public int? idcertificado { get; set; }

    [Column("do")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _do { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nconsdo { get; set; }
}
