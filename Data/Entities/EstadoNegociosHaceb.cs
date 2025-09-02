using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class EstadoNegociosHaceb
{
    [StringLength(100)]
    public string? TIPO { get; set; }

    [Column("Sucursal Operativa")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Sucursal_Operativa { get; set; }

    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCreacion { get; set; }

    public string? Mercancia { get; set; }

    [Column("Orden de Compra/Pedido")]
    public string? Orden_de_Compra_Pedido { get; set; }

    [Column("Fecha Orden", TypeName = "smalldatetime")]
    public DateTime? Fecha_Orden { get; set; }

    public string? Proveedor { get; set; }

    [Column("Nro Factura")]
    public string? Nro_Factura { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Deposito { get; set; }

    [Column("Modo Transporte")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_Transporte { get; set; }

    [StringLength(200)]
    public string? Embarcador { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Naviera { get; set; }

    [Column("Transportador Internacional")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Transportador_Internacional { get; set; }

    [Column("Tipo Carga")]
    [StringLength(202)]
    [Unicode(false)]
    public string? Tipo_Carga { get; set; }

    [Column("Peso Bruto", TypeName = "decimal(38, 2)")]
    public decimal? Peso_Bruto { get; set; }

    [Column("Nro Bultos")]
    public string? Nro_Bultos { get; set; }

    [Column("Cont. 20")]
    public int? Cont__20 { get; set; }

    [Column("Cont. 40")]
    public int? Cont__40 { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Volumen { get; set; }

    [Column("Fecha Estimada de Arribo", TypeName = "datetime")]
    public DateTime? Fecha_Estimada_de_Arribo { get; set; }

    [Column("Recepción Documentos Originales", TypeName = "datetime")]
    public DateTime? Recepción_Documentos_Originales { get; set; }

    [Column("Fecha de Envío de Originales", TypeName = "datetime")]
    public DateTime? Fecha_de_Envío_de_Originales { get; set; }

    [Column("Fecha Real Motonave", TypeName = "datetime")]
    public DateTime? Fecha_Real_Motonave { get; set; }

    [Column("Fecha de Liberación", TypeName = "datetime")]
    public DateTime? Fecha_de_Liberación { get; set; }

    [Column("Fecha Documentos Transportador", TypeName = "datetime")]
    public DateTime? Fecha_Documentos_Transportador { get; set; }

    [Column("Fecha Levante", TypeName = "smalldatetime")]
    public DateTime? Fecha_Levante { get; set; }

    [Unicode(false)]
    public string? Situación { get; set; }
}
