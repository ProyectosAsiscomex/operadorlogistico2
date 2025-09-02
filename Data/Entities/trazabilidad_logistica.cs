using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class trazabilidad_logistica
{
    [StringLength(22)]
    [Unicode(false)]
    public string ESTADO { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? Importador { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Identificacion { get; set; }

    [Column("Orden de Compra/Pedido")]
    public string Orden_de_Compra_Pedido { get; set; } = null!;

    [Column("Fecha Orden")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Orden { get; set; }

    [Column("D.O ADX")]
    [StringLength(50)]
    [Unicode(false)]
    public string? D_O_ADX { get; set; }

    [Unicode(false)]
    public string? Situación { get; set; }

    public string? Proveedor { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("Nombre Producto")]
    [Unicode(false)]
    public string? Nombre_Producto { get; set; }

    [Column("Total Piezas", TypeName = "decimal(38, 6)")]
    public decimal? Total_Piezas { get; set; }

    [Column("Cant. Piezas", TypeName = "decimal(30, 6)")]
    public decimal? Cant__Piezas { get; set; }

    [Column("Precio Unitario", TypeName = "decimal(30, 8)")]
    public decimal? Precio_Unitario { get; set; }

    [Column("Peso Bruto", TypeName = "decimal(30, 6)")]
    public decimal? Peso_Bruto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Volumen { get; set; }

    [Column("Valor Item", TypeName = "money")]
    public decimal? Valor_Item { get; set; }

    [StringLength(10)]
    public string? Moneda { get; set; }

    [Column("% Arancel", TypeName = "decimal(30, 2)")]
    public decimal? __Arancel { get; set; }

    [StringLength(20)]
    public string? Subpartida { get; set; }

    [StringLength(10)]
    public string? INCOTERM { get; set; }

    [Column("TRM Declaracion", TypeName = "decimal(30, 8)")]
    public decimal TRM_Declaracion { get; set; }

    [Column("Pais de Origen")]
    [StringLength(50)]
    public string? Pais_de_Origen { get; set; }

    [Column("Puerto/Aeropuero Origen")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Puerto_Aeropuero_Origen { get; set; }

    [Column("Puerto/Aeropuerto Destino")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Puerto_Aeropuerto_Destino { get; set; }

    [Column("Modo Transporte")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_Transporte { get; set; }

    [Column("Forma de Pago")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Forma_de_Pago { get; set; }

    [Column("Fecha Estimada Pago", TypeName = "datetime")]
    public DateTime? Fecha_Estimada_Pago { get; set; }

    [Column("Fecha Real Pago", TypeName = "datetime")]
    public DateTime? Fecha_Real_Pago { get; set; }

    [Column("Fecha Estimada de entrega Proveedor")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Estimada_de_entrega_Proveedor { get; set; }

    [Column("Fecha entrega del proveedor")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_entrega_del_proveedor { get; set; }

    [Column("Fecha Estimada de Zarpe")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Estimada_de_Zarpe { get; set; }

    [Column("Entrega de la mercancia para embarque")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Entrega_de_la_mercancia_para_embarque { get; set; }

    [Column("Fecha Real Motonave")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Real_Motonave { get; set; }

    [Column("Fecha Estimada de Arribo")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Estimada_de_Arribo { get; set; }

    [Column("Nro Facturas")]
    public string Nro_Facturas { get; set; } = null!;

    [Column("Fecha Factura")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Factura { get; set; }

    [Column("Nro BL/Guia")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_BL_Guia { get; set; }

    [Column("Fecha BL/Guia")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_BL_Guia { get; set; }

    [Column("Numero Contenedor")]
    public string? Numero_Contenedor { get; set; }

    [Column("Tamaño Contenedor")]
    public string? Tamaño_Contenedor { get; set; }

    [Column("Recepción Documentos Originales")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Recepción_Documentos_Originales { get; set; }

    [Column("Fecha de Envío de Originales")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_de_Envío_de_Originales { get; set; }

    [Column("Fecha Levante")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Levante { get; set; }

    [Column("Mes Levante")]
    [StringLength(30)]
    public string? Mes_Levante { get; set; }

    [Column("Fecha Documentos Transportador")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Documentos_Transportador { get; set; }

    [Column("Transportador Nacional")]
    [StringLength(100)]
    public string? Transportador_Nacional { get; set; }

    [Column("Llegada de la mercancía a Destino Nacional")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Llegada_de_la_mercancía_a_Destino_Nacional { get; set; }

    [Column("Fecha Devolucion Contenedor")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Devolucion_Contenedor { get; set; }

    [Column("Lugar Devolucion")]
    public string? Lugar_Devolucion { get; set; }

    [Column("Dias Libres")]
    public byte? Dias_Libres { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Novedades { get; set; }

    [Column("Tiempo de Transito")]
    public int? Tiempo_de_Transito { get; set; }

    public int? Nacionalizacion { get; set; }

    [Column("Puerto-Planta")]
    public int? Puerto_Planta { get; set; }

    [Column("FACTURA PROVEEDOR INTERNACIONAL", TypeName = "decimal(30, 2)")]
    public decimal? FACTURA_PROVEEDOR_INTERNACIONAL { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal TRM { get; set; }

    [Column("FLETE INTERNACIONAL EN FACTURA", TypeName = "decimal(38, 6)")]
    public decimal? FLETE_INTERNACIONAL_EN_FACTURA { get; set; }

    [Column("FLETE INTERNACIONAL EN DOCUMENTO DE TRANSPORTE", TypeName = "money")]
    public decimal FLETE_INTERNACIONAL_EN_DOCUMENTO_DE_TRANSPORTE { get; set; }

    [Column("FACTURA FLETE INTERNACIONAL EN DOCUMENTO DE TRANSPORTE")]
    public string? FACTURA_FLETE_INTERNACIONAL_EN_DOCUMENTO_DE_TRANSPORTE { get; set; }

    [Column("FLETE NACIONAL", TypeName = "money")]
    public decimal FLETE_NACIONAL { get; set; }

    [Column("FACTURA FLETE NACIONAL")]
    public string? FACTURA_FLETE_NACIONAL { get; set; }

    [Column(TypeName = "money")]
    public decimal? ADUANA { get; set; }

    [Column("FACTURA ADUANA")]
    [StringLength(50)]
    public string? FACTURA_ADUANA { get; set; }

    [Column("FECHA FACTURA ADUANA")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_FACTURA_ADUANA { get; set; }

    [Column(TypeName = "money")]
    public decimal? ARANCEL { get; set; }

    [Column(TypeName = "money")]
    public decimal? IVA { get; set; }

    [Column("TOTAL  GASTOS SIN IVA", TypeName = "money")]
    public decimal? TOTAL__GASTOS_SIN_IVA { get; set; }

    [Column("DIFERENCIA EN CAMBIO", TypeName = "money")]
    public decimal DIFERENCIA_EN_CAMBIO { get; set; }

    [Column("GASTOS REALES / DOLARES", TypeName = "decimal(38, 15)")]
    public decimal? GASTOS_REALES___DOLARES { get; set; }

    [Column("TOTAL GASTOS IMPORTACION USD", TypeName = "decimal(38, 10)")]
    public decimal? TOTAL_GASTOS_IMPORTACION_USD { get; set; }

    [Column("FACTURA PROVEEDOR ITEM", TypeName = "decimal(38, 6)")]
    public decimal? FACTURA_PROVEEDOR_ITEM { get; set; }

    [Column("FLETE INTERNACIONAL ITEM", TypeName = "decimal(38, 6)")]
    public decimal? FLETE_INTERNACIONAL_ITEM { get; set; }

    [Column("FLETE NACIONAL ITEM", TypeName = "decimal(38, 6)")]
    public decimal? FLETE_NACIONAL_ITEM { get; set; }

    [Column("ADUANAS ITEM", TypeName = "decimal(38, 6)")]
    public decimal? ADUANAS_ITEM { get; set; }

    [Column("ARANCEL ITEM", TypeName = "decimal(38, 6)")]
    public decimal? ARANCEL_ITEM { get; set; }

    [Column("IVA ITEM", TypeName = "decimal(38, 6)")]
    public decimal? IVA_ITEM { get; set; }

    [Column("DIFERENCIA EN CAMBIO ITEM", TypeName = "decimal(38, 6)")]
    public decimal? DIFERENCIA_EN_CAMBIO_ITEM { get; set; }

    [Column("TOTAL GASTOS SIN IVA ITEM", TypeName = "decimal(38, 6)")]
    public decimal? TOTAL_GASTOS_SIN_IVA_ITEM { get; set; }

    [Column("GASTOS REALES / DOLARES ITEM", TypeName = "decimal(38, 6)")]
    public decimal? GASTOS_REALES___DOLARES_ITEM { get; set; }

    [Column("TOTAL GASTOS IMPORTACION ITEM", TypeName = "decimal(38, 6)")]
    public decimal? TOTAL_GASTOS_IMPORTACION_ITEM { get; set; }

    [Column("FACTOR DE IMPORTACION", TypeName = "decimal(38, 6)")]
    public decimal? FACTOR_DE_IMPORTACION { get; set; }

    [Column("FACTOR TOTAL DE IMPORTACION", TypeName = "decimal(38, 8)")]
    public decimal? FACTOR_TOTAL_DE_IMPORTACION { get; set; }
}
