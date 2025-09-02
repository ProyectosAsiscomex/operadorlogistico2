using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturasItem")]
public partial class FacturasItem
{
    [Key]
    public int idfacturaitem { get; set; }

    public int? idfactura { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? tipo { get; set; }

    public int? idconcepto { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? comision { get; set; }

    [Column(TypeName = "money")]
    public decimal? comisionusd { get; set; }

    [StringLength(100)]
    public string? nrocheque { get; set; }

    [StringLength(100)]
    public string? nrorecibo { get; set; }

    [Column(TypeName = "money")]
    public decimal? retefuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteica { get; set; }

    [Column(TypeName = "money")]
    public decimal? valoriva { get; set; }

    public int? idcausacionesitem { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasa { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? trm { get; set; }

    public bool? usd { get; set; }

    public int? idgasto { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? valorcotizado { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasacambio { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? valornota { get; set; }
}
