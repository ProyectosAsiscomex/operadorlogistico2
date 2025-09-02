using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Fact_Cronograma
{
    public int IDDO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? empresa { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? contacto { get; set; }

    [Column("Llegada Mercancia", TypeName = "datetime")]
    public DateTime? Llegada_Mercancia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vaciado { get; set; }

    [Column("Cuenta de Fletes", TypeName = "datetime")]
    public DateTime? Cuenta_de_Fletes { get; set; }

    [Column("Recibo Originales", TypeName = "datetime")]
    public DateTime? Recibo_Originales { get; set; }

    [Column("Ingreso Mercancia Bodega", TypeName = "datetime")]
    public DateTime? Ingreso_Mercancia_Bodega { get; set; }

    [Column("Selectividad Aduanera", TypeName = "datetime")]
    public DateTime? Selectividad_Aduanera { get; set; }

    [Column("Inpeccion Aduanera", TypeName = "datetime")]
    public DateTime? Inpeccion_Aduanera { get; set; }

    [Column("Autorizacion Embarque", TypeName = "datetime")]
    public DateTime? Autorizacion_Embarque { get; set; }

    [Column("Radicacion Documento Deposito", TypeName = "datetime")]
    public DateTime? Radicacion_Documento_Deposito { get; set; }

    [Column("Entrega de documentos a transporte", TypeName = "datetime")]
    public DateTime? Entrega_de_documentos_a_transporte { get; set; }

    [Column("Fecha Real Embarque", TypeName = "datetime")]
    public DateTime? Fecha_Real_Embarque { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Originales { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Radicacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AceptacionDTA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PagoDTA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LevanteDTA { get; set; }

    [Column("Solicitud de Anticipos", TypeName = "smalldatetime")]
    public DateTime? Solicitud_de_Anticipos { get; set; }

    [Column("Recibo Anticipos", TypeName = "smalldatetime")]
    public DateTime? Recibo_Anticipos { get; set; }

    [Column("Radicacion Aceptacion", TypeName = "smalldatetime")]
    public DateTime? Radicacion_Aceptacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Aceptacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Pago { get; set; }

    [Column("Ingreso Sistema Dian", TypeName = "smalldatetime")]
    public DateTime? Ingreso_Sistema_Dian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Situacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Levante { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Entregado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Despacho { get; set; }

    [Column("Llegada Mercancia y Entrega Originales", TypeName = "decimal(8, 1)")]
    public decimal? Llegada_Mercancia_y_Entrega_Originales { get; set; }

    [Column("Entrega originales y solicitud de anticipo", TypeName = "decimal(8, 1)")]
    public decimal? Entrega_originales_y_solicitud_de_anticipo { get; set; }

    [Column("Solicitud y entrega de anticipo", TypeName = "decimal(8, 1)")]
    public decimal? Solicitud_y_entrega_de_anticipo { get; set; }

    [Column("Entrega originales y entrega anticipos", TypeName = "decimal(8, 1)")]
    public decimal? Entrega_originales_y_entrega_anticipos { get; set; }

    [Column("Entrega originales y Presentacion DIAN", TypeName = "decimal(8, 1)")]
    public decimal? Entrega_originales_y_Presentacion_DIAN { get; set; }

    [Column("Entrega anticipos y Presentación DIAN", TypeName = "decimal(8, 1)")]
    public decimal? Entrega_anticipos_y_Presentación_DIAN { get; set; }

    [Column("Presentación DIAN y entrega de la mercancia", TypeName = "decimal(8, 1)")]
    public decimal? Presentación_DIAN_y_entrega_de_la_mercancia { get; set; }

    [Column("Tiempo de servicio")]
    public int Tiempo_de_servicio { get; set; }

    [Column("Llegada mercancia y Despacho mercancia", TypeName = "decimal(8, 1)")]
    public decimal? Llegada_mercancia_y_Despacho_mercancia { get; set; }

    [Column("Ingreso Mercancia y Entrega Autorizacion", TypeName = "decimal(8, 1)")]
    public decimal? Ingreso_Mercancia_y_Entrega_Autorizacion { get; set; }

    [Column("Entrega Originales y Presentacion DIANEX", TypeName = "decimal(8, 1)")]
    public decimal? Entrega_Originales_y_Presentacion_DIANEX { get; set; }

    [Column("Entrega Anticipos y Presentacion DIAN", TypeName = "decimal(8, 1)")]
    public decimal? Entrega_Anticipos_y_Presentacion_DIAN { get; set; }

    [Column("Presentacion DIAN y Autorizacion Embarque", TypeName = "decimal(8, 1)")]
    public decimal? Presentacion_DIAN_y_Autorizacion_Embarque { get; set; }
}
