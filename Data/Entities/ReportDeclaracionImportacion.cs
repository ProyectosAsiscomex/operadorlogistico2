using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class ReportDeclaracionImportacion
{
    [Column("Año Declaración")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Año_Declaración { get; set; }

    [Column("Nro formulario")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_formulario { get; set; }

    [Column("Nro Auxiliar")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Auxiliar { get; set; }

    [Column("Fecha Auxiliar", TypeName = "smalldatetime")]
    public DateTime? Fecha_Auxiliar { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Importador { get; set; }

    public int? idexportador { get; set; }

    [StringLength(100)]
    public string? Aduana { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Declarante { get; set; }

    [StringLength(400)]
    public string? Signatario { get; set; }

    [Column("Cedula Signatario")]
    [StringLength(100)]
    public string? Cedula_Signatario { get; set; }

    [Column("Clase importador")]
    [StringLength(7)]
    [Unicode(false)]
    public string? Clase_importador { get; set; }

    [Column("Tipo declaracion")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Tipo_declaracion { get; set; }

    [Column("Nro formulario Anterior")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_formulario_Anterior { get; set; }

    [Column("Fecha formulario anterior", TypeName = "smalldatetime")]
    public DateTime? Fecha_formulario_anterior { get; set; }

    [Column("Aduana Formulario Anterior")]
    [StringLength(100)]
    public string? Aduana_Formulario_Anterior { get; set; }

    [Column("Nro declaracion exportacion")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Nro_declaracion_exportacion { get; set; }

    [Column("Fecha declaracion exportacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_declaracion_exportacion { get; set; }

    [Column("Aduana de exportacion")]
    [StringLength(100)]
    public string? Aduana_de_exportacion { get; set; }

    [Column("Lugar Ingreso Mercancia")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Lugar_Ingreso_Mercancia { get; set; }

    [Column("Deposito Habilitado")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Deposito_Habilitado { get; set; }

    [Column("Nro Manifiesto de Carga")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Nro_Manifiesto_de_Carga { get; set; }

    [Column("Fecha Manifiesto Carga", TypeName = "smalldatetime")]
    public DateTime? Fecha_Manifiesto_Carga { get; set; }

    [Column("Nro Documento de Transporte")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Nro_Documento_de_Transporte { get; set; }

    [Column("Fecha Documento de Transporte", TypeName = "smalldatetime")]
    public DateTime? Fecha_Documento_de_Transporte { get; set; }

    public string? Proveedor { get; set; }

    [Column("Nro Factura")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Factura { get; set; }

    [Column("Fecha Factura", TypeName = "smalldatetime")]
    public DateTime? Fecha_Factura { get; set; }

    [Column("Pais de Procedencia")]
    [StringLength(50)]
    public string? Pais_de_Procedencia { get; set; }

    [Column("Modo Transporte")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_Transporte { get; set; }

    [Column("Codigo de Bandera")]
    [StringLength(50)]
    public string? Codigo_de_Bandera { get; set; }

    [Column("Departamento Destino")]
    [StringLength(40)]
    public string? Departamento_Destino { get; set; }

    [Column("Empresa transportadora")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Empresa_transportadora { get; set; }

    [Column(TypeName = "money")]
    public decimal? TRM { get; set; }

    [Column("Subpartida arancelaria")]
    [StringLength(20)]
    public string? Subpartida_arancelaria { get; set; }

    [Column("Cod Complementario")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Cod_Complementario { get; set; }

    [Column("Cod Suplementario")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Cod_Suplementario { get; set; }

    public string? Modalidad { get; set; }

    [Column("Nro Cuotas")]
    public int? Nro_Cuotas { get; set; }

    [Column("Vl Cuota USD", TypeName = "decimal(30, 2)")]
    public decimal? Vl_Cuota_USD { get; set; }

    [Column("Periocidad Pago Cuota", TypeName = "decimal(30, 2)")]
    public decimal? Periocidad_Pago_Cuota { get; set; }

    [Column("Pais de Origen")]
    [StringLength(50)]
    public string? Pais_de_Origen { get; set; }

    [Column("Cod Acuerdo")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Cod_Acuerdo { get; set; }

    [Column("Forma de Pago")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Forma_de_Pago { get; set; }

    [Column("Tipo Importacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Tipo_Importacion { get; set; }

    [Column("Pais de Compra")]
    [StringLength(50)]
    public string? Pais_de_Compra { get; set; }

    [Column("Peso bruto kgs", TypeName = "decimal(30, 2)")]
    public decimal? Peso_bruto_kgs { get; set; }

    [Column("Peso neto kgs", TypeName = "decimal(30, 2)")]
    public decimal? Peso_neto_kgs { get; set; }

    [Column("Cod Embalaje")]
    public int? Cod_Embalaje { get; set; }

    [Column("Nro bultos", TypeName = "decimal(30, 2)")]
    public decimal? Nro_bultos { get; set; }

    public int? Subpartidas { get; set; }

    [Column("Unidad Fisica")]
    [StringLength(20)]
    public string? Unidad_Fisica { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Cantidad { get; set; }

    [Column("Valor FOB USD", TypeName = "money")]
    public decimal? Valor_FOB_USD { get; set; }

    [Column("Valor Flete USD", TypeName = "money")]
    public decimal? Valor_Flete_USD { get; set; }

    [Column("Valor Seguros USD", TypeName = "money")]
    public decimal? Valor_Seguros_USD { get; set; }

    [Column("Valor otros gastos USD", TypeName = "money")]
    public decimal? Valor_otros_gastos_USD { get; set; }

    [Column("Suma de fletes,seguros y otros gastos USD", TypeName = "money")]
    public decimal? Suma_de_fletes_seguros_y_otros_gastos_USD { get; set; }

    [Column("Ajuste valor USD", TypeName = "decimal(30, 2)")]
    public decimal? Ajuste_valor_USD { get; set; }

    [Column("Valor Aduana USD", TypeName = "money")]
    public decimal? Valor_Aduana_USD { get; set; }

    [Column("Cód.Registro o licencia")]
    public int? Cód_Registro_o_licencia { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Número { get; set; }

    [Column("Cod Oficina")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod_Oficina { get; set; }

    public int? Año { get; set; }

    [Column("Nro Programa")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Nro_Programa { get; set; }

    [Column("Cod Producto")]
    [StringLength(10)]
    public string? Cod_Producto { get; set; }

    [Column("% Arancel", TypeName = "decimal(30, 2)")]
    public decimal? __Arancel { get; set; }

    [Column("Base Arancel", TypeName = "money")]
    public decimal? Base_Arancel { get; set; }

    [Column("Total liquidado arancel en Pesos", TypeName = "money")]
    public decimal? Total_liquidado_arancel_en_Pesos { get; set; }

    [Column("Total a pagar con esta declaracion arancel en pesos", TypeName = "money")]
    public decimal? Total_a_pagar_con_esta_declaracion_arancel_en_pesos { get; set; }

    [Column("Total liquidado Arancel dólares(USD)", TypeName = "money")]
    public decimal? Total_liquidado_Arancel_dólares_USD_ { get; set; }

    [Column("% IVA", TypeName = "decimal(30, 2)")]
    public decimal? __IVA { get; set; }

    [Column("Base IVA", TypeName = "money")]
    public decimal? Base_IVA { get; set; }

    [Column("Total liquidado IVA en Pesos", TypeName = "money")]
    public decimal? Total_liquidado_IVA_en_Pesos { get; set; }

    [Column("Total a pagar con esta declaracion pesos($)IVA ", TypeName = "money")]
    public decimal? Total_a_pagar_con_esta_declaracion_pesos___IVA_ { get; set; }

    [Column("Total liquidado IVA dólares(USD)", TypeName = "money")]
    public decimal? Total_liquidado_IVA_dólares_USD_ { get; set; }

    [Column("% Salvaguardia", TypeName = "decimal(30, 2)")]
    public decimal? __Salvaguardia { get; set; }

    [Column("Base Salvaguardia", TypeName = "money")]
    public decimal? Base_Salvaguardia { get; set; }

    [Column("Total liquidado Salvaguardia en Pesos", TypeName = "money")]
    public decimal? Total_liquidado_Salvaguardia_en_Pesos { get; set; }

    [Column("Total a pagar con esta declaracion pesos($)Salvaguardia ", TypeName = "money")]
    public decimal? Total_a_pagar_con_esta_declaracion_pesos___Salvaguardia_ { get; set; }

    [Column("Total liquidado salvaguardia dólares(USD)", TypeName = "money")]
    public decimal? Total_liquidado_salvaguardia_dólares_USD_ { get; set; }

    [Column("%Derechos compensatorios", TypeName = "decimal(30, 2)")]
    public decimal? _Derechos_compensatorios { get; set; }

    [Column("Base derechos compensatorios", TypeName = "money")]
    public decimal? Base_derechos_compensatorios { get; set; }

    [Column("Total liquidado derechos compensatorios pesos", TypeName = "money")]
    public decimal? Total_liquidado_derechos_compensatorios_pesos { get; set; }

    [Column("Total a pagar con esta declaracion pesos($)Der Compensatorios ", TypeName = "money")]
    public decimal? Total_a_pagar_con_esta_declaracion_pesos___Der_Compensatorios_ { get; set; }

    [Column("Total liquidado Der Compensatorios dólares(USD)", TypeName = "money")]
    public decimal? Total_liquidado_Der_Compensatorios_dólares_USD_ { get; set; }

    [Column("% Derechos Antidumping", TypeName = "decimal(30, 2)")]
    public decimal? __Derechos_Antidumping { get; set; }

    [Column("Base derechos Antidumping", TypeName = "money")]
    public decimal? Base_derechos_Antidumping { get; set; }

    [Column("Total liquidado derechos Antidumping pesos", TypeName = "money")]
    public decimal? Total_liquidado_derechos_Antidumping_pesos { get; set; }

    [Column("Total a pagar con esta declaracion pesos($)Antidumping", TypeName = "money")]
    public decimal? Total_a_pagar_con_esta_declaracion_pesos___Antidumping { get; set; }

    [Column("Total liquidado Antidumping dólares(USD)", TypeName = "money")]
    public decimal? Total_liquidado_Antidumping_dólares_USD_ { get; set; }

    [Column("% Sancion", TypeName = "decimal(30, 2)")]
    public decimal? __Sancion { get; set; }

    [Column("Base Sanción", TypeName = "money")]
    public decimal? Base_Sanción { get; set; }

    [Column("total liquidado Sancion", TypeName = "money")]
    public decimal? total_liquidado_Sancion { get; set; }

    [Column("Total a pagar con esta declaracion pesos($)Sancion", TypeName = "money")]
    public decimal? Total_a_pagar_con_esta_declaracion_pesos___Sancion { get; set; }

    [Column("% Rescate", TypeName = "decimal(30, 2)")]
    public decimal? __Rescate { get; set; }

    [Column("Base rescate", TypeName = "money")]
    public decimal? Base_rescate { get; set; }

    [Column("total liquidado rescate", TypeName = "money")]
    public decimal? total_liquidado_rescate { get; set; }

    [Column("Total a pagar Rescate", TypeName = "money")]
    public decimal? Total_a_pagar_Rescate { get; set; }

    [Column("Total liquidado Pesos", TypeName = "money")]
    public decimal? Total_liquidado_Pesos { get; set; }

    [Column("Total liquidado USD", TypeName = "money")]
    public decimal? Total_liquidado_USD { get; set; }

    [Column("valor pagos Anteriores", TypeName = "money")]
    public decimal? valor_pagos_Anteriores { get; set; }

    [Column("Recibo oficial de pago anterior No.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Recibo_oficial_de_pago_anterior_No_ { get; set; }

    [Column("Fecha recibo pago anterior", TypeName = "smalldatetime")]
    public DateTime? Fecha_recibo_pago_anterior { get; set; }

    [Column("Nro Aceptación")]
    [StringLength(100)]
    public string? Nro_Aceptación { get; set; }

    [Column("Fecha aceptacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_aceptacion { get; set; }

    [Column("Nro Levante")]
    public long? Nro_Levante { get; set; }

    [Column("Fecha Levante", TypeName = "smalldatetime")]
    public DateTime? Fecha_Levante { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("C.C")]
    public int? C_C { get; set; }

    [Column("Pago total", TypeName = "money")]
    public decimal? Pago_total { get; set; }

    [Column("C Origen")]
    [StringLength(5)]
    [Unicode(false)]
    public string? C_Origen { get; set; }

    [Column("Nro Sticker")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Sticker { get; set; }

    [Column("Fecha Sticker")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Fecha_Sticker { get; set; }

    [Column("Nro Certificado")]
    [StringLength(30)]
    public string? Nro_Certificado { get; set; }

    [Column("Nro declaracion de cambio")]
    [StringLength(30)]
    public string? Nro_declaracion_de_cambio { get; set; }

    [Column("Fecha declaración de cambio", TypeName = "smalldatetime")]
    public DateTime? Fecha_declaración_de_cambio { get; set; }

    [Column("Descripción Mercancia")]
    [Unicode(false)]
    public string? Descripción_Mercancia { get; set; }
}
