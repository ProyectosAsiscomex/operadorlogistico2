using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class AutorizacionEmbarqueReport
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Exportador { get; set; }

    public int? idxportador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Declarante { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Destinatario { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    [Column("Nro Formulario")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Formulario { get; set; }

    [Column("Nro formulario anterior")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_formulario_anterior { get; set; }

    [Column("Nro referencia")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_referencia { get; set; }

    [Column("Nro autorizacion global")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_autorizacion_global { get; set; }

    [Column("Nro programa MSVC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_programa_MSVC { get; set; }

    [Column("Regimen Aduanero")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Regimen_Aduanero { get; set; }

    [Column("Aduana despacho")]
    [StringLength(100)]
    public string? Aduana_despacho { get; set; }

    public int? idaduana { get; set; }

    [Column("Región procedencia")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Región_procedencia { get; set; }

    [Column("Tipo embarque")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_embarque { get; set; }

    [Column("Tipo Datos")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Datos { get; set; }

    [Column("Naturaleza Transacción")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Naturaleza_Transacción { get; set; }

    [Column("Tipo Solicitud")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Solicitud { get; set; }

    [StringLength(100)]
    public string? INCOTERM { get; set; }

    [Column("Lugar entrega")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Lugar_entrega { get; set; }

    [StringLength(100)]
    public string? Moneda { get; set; }

    [Column("Valor Factura", TypeName = "money")]
    public decimal? Valor_Factura { get; set; }

    [Column("Tasa Cambio")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tasa_Cambio { get; set; }

    [Column("Forma de pago")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Forma_de_pago { get; set; }

    [Column("Cantidad pagos anticipados")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cantidad_pagos_anticipados { get; set; }

    [Column("Fecha primer pago anticipo", TypeName = "smalldatetime")]
    public DateTime? Fecha_primer_pago_anticipo { get; set; }

    [Column("Mrcancia mano del viajero")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Mrcancia_mano_del_viajero { get; set; }

    [Column("Sistemas Especiales")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Sistemas_Especiales { get; set; }

    [Column("Exportacion en Transito")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Exportacion_en_Transito { get; set; }

    [Column("Mercancia en Zona primaria")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Mercancia_en_Zona_primaria { get; set; }

    [Column("Modo de transporte")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_de_transporte { get; set; }

    [Column("Tipo carga")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_carga { get; set; }

    [Column("Nro Viaje")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Viaje { get; set; }

    [Column("Aduana de Salida")]
    [StringLength(100)]
    public string? Aduana_de_Salida { get; set; }

    [Column("Lugar Embarque")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Lugar_Embarque { get; set; }

    [StringLength(50)]
    public string? País { get; set; }

    [Column("Lugar destino")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Lugar_destino { get; set; }

    [Column("Lugar destino final Colombia")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Lugar_destino_final_Colombia { get; set; }

    [Column("Depósito habilitado")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Depósito_habilitado { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Transportador { get; set; }

    [Column("Lugar Inspección")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Lugar_Inspección { get; set; }

    [Column("Nro aprovacion inspección")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_aprovacion_inspección { get; set; }

    [Column("Dirección ubicación mcia")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Dirección_ubicación_mcia { get; set; }

    [Column("Solicita inspección fisica")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Solicita_inspección_fisica { get; set; }

    [Column("Valor total Fletes USD", TypeName = "money")]
    public decimal? Valor_total_Fletes_USD { get; set; }

    [Column("Valor total Seguros USD", TypeName = "money")]
    public decimal? Valor_total_Seguros_USD { get; set; }

    [Column("Valor total otros gastos USD", TypeName = "money")]
    public decimal? Valor_total_otros_gastos_USD { get; set; }

    [Column("Valor a reintegrar USD", TypeName = "money")]
    public decimal? Valor_a_reintegrar_USD { get; set; }

    [Column("Nro DO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column("Nro Radicado")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Radicado { get; set; }

    [Column("Sede Operativa")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Sede_Operativa { get; set; }

    [Column("Nro Envio")]
    public int? Nro_Envio { get; set; }

    [Column("Fecha Creacion", TypeName = "datetime")]
    public DateTime? Fecha_Creacion { get; set; }

    [Column("Ultima Modificacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Ultima_Modificacion { get; set; }

    [Column("DEX Definitivo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DEX_Definitivo { get; set; }

    [Column("Fecha DEX Definitivo", TypeName = "smalldatetime")]
    public DateTime? Fecha_DEX_Definitivo { get; set; }

    [Column("Tipo de Operación")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_de_Operación { get; set; }

    [Column("Estado SAE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Estado_SAE { get; set; }

    [Column("Usuario Digitador")]
    [StringLength(401)]
    public string Usuario_Digitador { get; set; } = null!;

    [Column("Usuario Revisor")]
    [StringLength(401)]
    public string Usuario_Revisor { get; set; } = null!;

    [Column("Fecha Aceptación")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Aceptación { get; set; }

    [Column("Origen SAE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Origen_SAE { get; set; }

    [Column("Sede Digitadora")]
    [StringLength(100)]
    public string? Sede_Digitadora { get; set; }

    [Column("Fecha Autorización")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Autorización { get; set; }

    [StringLength(50)]
    public string? DexProvisional { get; set; }

    [Column("Fecha Dex provisional")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Dex_provisional { get; set; }

    public int? Grupo { get; set; }

    [Column("Subpartida Datos serie")]
    [StringLength(20)]
    public string? Subpartida_Datos_serie { get; set; }

    [Column("Codigo complementario")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo_complementario { get; set; }

    [Column("Codigo suplementario")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo_suplementario { get; set; }

    [Column("Codigo unidad Fisica")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo_unidad_Fisica { get; set; }

    [Column("Cantidad unidad Fisica", TypeName = "decimal(30, 2)")]
    public decimal? Cantidad_unidad_Fisica { get; set; }

    [Column("Codigo unidad comercial")]
    [StringLength(10)]
    public string? Codigo_unidad_comercial { get; set; }

    [Column("Cantidad unidad comercial", TypeName = "decimal(30, 2)")]
    public decimal? Cantidad_unidad_comercial { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? idembalaje { get; set; }

    [Column("Nro Bultos", TypeName = "decimal(30, 2)")]
    public decimal? Nro_Bultos { get; set; }

    [Column("Peso Bruto", TypeName = "decimal(30, 2)")]
    public decimal? Peso_Bruto { get; set; }

    [Column("Peso Neto", TypeName = "decimal(30, 2)")]
    public decimal? Peso_Neto { get; set; }

    [Column("Valor FOB1", TypeName = "decimal(30, 2)")]
    public decimal? Valor_FOB1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Marcas { get; set; }

    [Column("Descripción Mercancia")]
    [Unicode(false)]
    public string? Descripción_Mercancia { get; set; }

    [Column("Unidad Medida plazo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Unidad_Medida_plazo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Plazo { get; set; }

    [Column("País Origen Datos Serie")]
    [StringLength(50)]
    public string? País_Origen_Datos_Serie { get; set; }

    [Column("Cod Region Origen")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod_Region_Origen { get; set; }

    [Column("Preferencia Arancelaria")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Preferencia_Arancelaria { get; set; }

    [Column("Aduana precedente")]
    [StringLength(100)]
    public string? Aduana_precedente { get; set; }

    [Column(" Nro declaracion Precedente")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _Nro_declaracion_Precedente { get; set; }

    [Column("Años Aceptación")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Años_Aceptación { get; set; }

    [Column("Cod reg precedente")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod_reg_precedente { get; set; }

    [Column("Cod modalidad precedente")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod_modalidad_precedente { get; set; }

    [Column("Nro serie precedente")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_serie_precedente { get; set; }

    public short? serie { get; set; }

    [StringLength(300)]
    public string? Producto { get; set; }

    [Column("Nro Programa")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Programa { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? reposicion { get; set; }

    [Column("Nro CIP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_CIP { get; set; }

    [Column("Nro Producto")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Producto { get; set; }

    [Column("cantidad producto exportacion CIP", TypeName = "decimal(30, 2)")]
    public decimal? cantidad_producto_exportacion_CIP { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? VAN { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? VIE { get; set; }

    [Column("Valor FOB2", TypeName = "decimal(30, 15)")]
    public decimal? Valor_FOB2 { get; set; }

    [Column("Valor FOB CIP", TypeName = "decimal(30, 15)")]
    public decimal? Valor_FOB_CIP { get; set; }

    [Column("Tipo de Documento Soporte")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Tipo_de_Documento_Soporte { get; set; }

    [Column("Nro documento")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_documento { get; set; }

    [Column("Nit Emisor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nit_Emisor { get; set; }

    [Column(" DV Emisor")]
    [StringLength(1)]
    [Unicode(false)]
    public string? _DV_Emisor { get; set; }

    [Column("Fecha Expedición")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Expedición { get; set; }

    [Column("Fecha de Vencimiento")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_de_Vencimiento { get; set; }

    [Column("Moneda documentos soporte")]
    [StringLength(100)]
    public string? Moneda_documentos_soporte { get; set; }

    [Column("Monto Documento", TypeName = "decimal(30, 2)")]
    public decimal? Monto_Documento { get; set; }

    [Column("Unidad Comercial")]
    [StringLength(50)]
    public string? Unidad_Comercial { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Cantidad { get; set; }
}
