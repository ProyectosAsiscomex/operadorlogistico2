using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class OperacionesImpoDTum
{
    [StringLength(50)]
    [Unicode(false)]
    public string? NroDO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCreacion { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? razonsocial { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorsegurosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfletesusd { get; set; }

    [StringLength(100)]
    public string? TIPO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SucursalOperativa { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? PesoBruto { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Deposito { get; set; }

    [StringLength(50)]
    public string? nombre { get; set; }

    [StringLength(50)]
    public string? PaisCompra { get; set; }

    public string? Proveedor { get; set; }

    public string? Mercancia { get; set; }

    public int? Cont20 { get; set; }

    public int? Cont40 { get; set; }

    [StringLength(20)]
    public string? Subpartida { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ModoTransporte { get; set; }

    [StringLength(200)]
    public string? Embarcador { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Naviera { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? codacuerdo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRealMotonave { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaLevante { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecepciónDocumentosOriginales { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechadeManifiesto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaDocumentosTransportador { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRetirototal { get; set; }
}
