using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturasInterfaz")]
public partial class FacturasInterfaz
{
    [Key]
    public int idFactura { get; set; }

    [StringLength(50)]
    public string? NroFactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVence { get; set; }

    [StringLength(50)]
    public string? Tercero { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? tasacambio { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorcomision { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? tasavalorcomision { get; set; }

    [Column(TypeName = "money")]
    public decimal? fletecomision { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? tasafletecomision { get; set; }

    [Column(TypeName = "money")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? tasaotrosgastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? fleteinternacional { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? tasafleteinternacional { get; set; }

    [StringLength(50)]
    public string? nrofacturafletes { get; set; }

    [StringLength(50)]
    public string? fechafacturafletes { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? FleteNacional { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Valor_Itr { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? propios { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? terceros_siniva { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? tasacambioliquidacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nitflete { get; set; }

    [Column("do")]
    [StringLength(30)]
    public string? _do { get; set; }
}
