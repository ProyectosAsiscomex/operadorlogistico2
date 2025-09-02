using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class LiquidacionPrebel
{
    [StringLength(50)]
    public string? FACTURA_p { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaf { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechap { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string doc_base1 { get; set; } = null!;

    public string doc_base2 { get; set; } = null!;

    [StringLength(200)]
    public string? cod_servicio { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string tipo { get; set; } = null!;

    [StringLength(20)]
    public string? proveedor { get; set; }

    public long? Linea { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string moneda { get; set; } = null!;

    [Column("tasa de cambio moneda")]
    [StringLength(1)]
    [Unicode(false)]
    public string tasa_de_cambio_moneda { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? bruto_mon { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? bruto_loc { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? neto_mon { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? neto_loc { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string tieneiva { get; set; } = null!;

    [Column("valor iva", TypeName = "decimal(38, 2)")]
    public decimal? valor_iva { get; set; }

    [StringLength(200)]
    public string? factura_m { get; set; }
}
