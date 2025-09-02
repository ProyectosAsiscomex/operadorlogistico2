using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("LiquidaMadecentro1")]
public partial class LiquidaMadecentro1
{
    [StringLength(10)]
    public string? partida { get; set; }

    [StringLength(3)]
    public string? sub_par { get; set; }

    [StringLength(40)]
    public string? referencia { get; set; }

    [StringLength(3)]
    public string? unidad { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? peso_ref { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? valor_ref { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal? unitario { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? totalref { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? fletes_int { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? seguros { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? gastos { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? terceros { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? propios { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? gravamen { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? fletes_nal { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? bancarios { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? fletes_int_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? seguros_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? gastos_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? terceros_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? propios_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? gravamen_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? antidump_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? fletes_nal_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? bancarios_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? comision_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? itr_v { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? flete_pro_v { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? fob_refer { get; set; }

    [StringLength(5)]
    public string? unidad_cli { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? cantidad_u { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? precio_u { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? costo_unitario { get; set; }
}
