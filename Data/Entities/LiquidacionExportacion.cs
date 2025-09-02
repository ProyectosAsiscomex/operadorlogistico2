using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LiquidacionExportacion")]
public partial class LiquidacionExportacion
{
    [Key]
    public int idliquidacionexportacion { get; set; }

    public int? idexportador { get; set; }

    public int? idpedido { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? trm { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valortotalfob { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorfacturacomercialusd { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? totalfleteinternacionalusd { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? segurousd { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valortotalgastosusd { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? facturas { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? incoterm { get; set; }

    public bool? facturado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? UsuarioUltimaModificacion { get; set; }
}
