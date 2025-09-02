using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALIMPORTADORESDEF")]
public partial class TEMPORALIMPORTADORESDEF
{
    public double? ID_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_TIPO_ID { get; set; }

    [StringLength(255)]
    public string? NUMERO_IDENTIFICACION { get; set; }

    [StringLength(255)]
    public string? NOMBRE_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CIUDAD_DOMICILIO { get; set; }

    [StringLength(255)]
    public string? DIRECCION { get; set; }

    [StringLength(255)]
    public string? TELEFONO { get; set; }

    [StringLength(255)]
    public string? FAX { get; set; }

    [StringLength(255)]
    public string? EMAIL { get; set; }

    [StringLength(255)]
    public string? REPRESENTANTE_LEGAL { get; set; }

    [StringLength(255)]
    public string? CODIGO_TIPO_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_NIVEL_CCIAL { get; set; }

    [StringLength(255)]
    public string? ESPECIFIQUE { get; set; }

    [StringLength(255)]
    public string? CODIGO_ACT_ECONOMICA { get; set; }

    [StringLength(255)]
    public string? CODIGO_CLASE_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_TIPO_ACT { get; set; }

    [StringLength(255)]
    public string? CODIGO_ADMINISTRACION { get; set; }

    [StringLength(255)]
    public string? ID_TERCERO { get; set; }

    [StringLength(255)]
    public string? NOMBRE_CONTACTO { get; set; }

    [StringLength(255)]
    public string? CAPITAL_REGISTRADO { get; set; }

    [StringLength(255)]
    public string? APROBADO { get; set; }

    [StringLength(255)]
    public string? USUARIO_CREACION { get; set; }

    [StringLength(255)]
    public string? FECHA_CREACION { get; set; }

    [StringLength(255)]
    public string? USUARIO_MODIFICACION { get; set; }

    [StringLength(255)]
    public string? FECHA_MODIFICACION { get; set; }

    [StringLength(255)]
    public string? NOMBRE_CORTO { get; set; }

    [StringLength(255)]
    public string? EMAIL_CORRESPONDENCIA { get; set; }

    [StringLength(255)]
    public string? RECIBE_CORRESPONDENCIA { get; set; }

    [StringLength(255)]
    public string? REPORTE_DIARIO { get; set; }

    [StringLength(255)]
    public string? REPORTE_EVENTOS { get; set; }

    [StringLength(255)]
    public string? REPORTE_EVENTOS_DEFAULT { get; set; }

    public double? PORCENTAJE_SEGURO { get; set; }

    [StringLength(255)]
    public string? PRODUCTOS_POR_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_UAP { get; set; }

    [StringLength(255)]
    public string? MANEJO_BASE_DATOS { get; set; }

    [StringLength(255)]
    public string? RECIBE_COMENTARIOS { get; set; }

    public double? ID_ENTE { get; set; }

    [StringLength(255)]
    public string? PROGRAMA_AUTORIZADO { get; set; }

    [StringLength(255)]
    public string? TIPO_TERCERO { get; set; }

    [StringLength(255)]
    public string? ID_EMPLEADO_EJECUTIVO_CUENTA { get; set; }

    [StringLength(255)]
    public string? CODIGO_SUCURSAL_COMERCIAL { get; set; }

    [StringLength(255)]
    public string? NUMERO_MANDATO { get; set; }

    [StringLength(255)]
    public string? FECHA_MANDATO { get; set; }

    [StringLength(255)]
    public string? FECHA_VENCIMIENTO_MANDATO { get; set; }

    [StringLength(255)]
    public string? DIRECCION_ENTREGA_FACTURACION { get; set; }

    [StringLength(255)]
    public string? SOLICITAR_ANTICIPO { get; set; }

    [StringLength(255)]
    public string? CONCECUTIVO_DECLARACIONES_VALOR { get; set; }

    [StringLength(255)]
    public string? NUMERO_POLIZA_TEMPORALES { get; set; }

    [StringLength(255)]
    public string? FECHA_POLIZA_TEMPORALES { get; set; }

    [StringLength(255)]
    public string? ASEGURADORA { get; set; }

    [StringLength(255)]
    public string? NIT_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? FECHA_CIRCULAR_170 { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_CIRCULAR_170 { get; set; }

    [StringLength(255)]
    public string? FECHA_RUT { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_RUT { get; set; }

    [StringLength(255)]
    public string? FECHA_CAMARA_COMERCIO { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_CAMARA_COMERCIO { get; set; }

    [StringLength(255)]
    public string? FECHA_CEDULA { get; set; }

    [StringLength(255)]
    public string? FECHA_ESTADO_FINANCIERO { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_ESTADO_FINANCIERO { get; set; }

    [StringLength(255)]
    public string? FECHA_VISITA_DOMICILIARIA { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_VISITA_DOMICILIARIA { get; set; }

    [StringLength(255)]
    public string? NUMERO_LICENCIA_ANUAL { get; set; }

    [StringLength(255)]
    public string? FECHA_VENC_LICENCIA_ANUAL { get; set; }

    [StringLength(255)]
    public string? COLOR_ANTICIPO { get; set; }

    [StringLength(255)]
    public string? CODIGO_OFICINA_INCOMEX { get; set; }

    [StringLength(255)]
    public string? CIUDAD_CONTACTO { get; set; }

    [StringLength(255)]
    public string? ENTREGAR_BL_EXPORTACIONES { get; set; }

    [StringLength(255)]
    public string? CARGO_CONTACTO { get; set; }

    [StringLength(255)]
    public string? PARAMETRO_DESCRIPCION { get; set; }

    [StringLength(255)]
    public string? PARAMETRO_DESCRIPCION_DETALLE { get; set; }

    [StringLength(255)]
    public string? ES_INDUSTRIA_MINERA { get; set; }

    [StringLength(255)]
    public string? ID_EMPLEADO_CLASIFICADOR { get; set; }

    [StringLength(255)]
    public string? CLASIFICADOR_TODAS_SUCURSALES { get; set; }

    [StringLength(255)]
    public string? MODULO_CLASIFICACION { get; set; }

    [StringLength(255)]
    public string? FINANCIACION_IMPORTACION { get; set; }

    [StringLength(255)]
    public string? FINANCIACION_EXPORTACION { get; set; }

    [StringLength(255)]
    public string? FINANCIACION_DTA { get; set; }

    [StringLength(255)]
    public string? ANTICIPO_IMPORTACION { get; set; }

    [StringLength(255)]
    public string? ANTICIPO_EXPORTACION { get; set; }

    [StringLength(255)]
    public string? ANTICIPO_DTA { get; set; }

    [StringLength(255)]
    public string? DATOS_NEGOCIACION { get; set; }

    [StringLength(255)]
    public string? CONSECUTIVO_PEDIDO { get; set; }

    [StringLength(255)]
    public string? FECHA_GARANTIA_UAP { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_GARANTIA_UAP { get; set; }

    [StringLength(255)]
    public string? FECHA_RESOLUCION_UAP { get; set; }

    [StringLength(255)]
    public string? VENCIMIENTO_RESOLUCION_UAP { get; set; }

    [StringLength(255)]
    public string? CLIENTE_ACTIVO { get; set; }

    [StringLength(255)]
    public string? CLIENTE_CRITICO { get; set; }

    [StringLength(255)]
    public string? CARTA_COMPROMISO { get; set; }

    [StringLength(255)]
    public string? REFERENCIA_BANCARIA { get; set; }

    [StringLength(255)]
    public string? TIENE_FOTOGRAFIAS { get; set; }

    [StringLength(255)]
    public string? TIENE_BASC { get; set; }

    [StringLength(255)]
    public string? FECHA_EXPEDICION_BASC { get; set; }

    [StringLength(255)]
    public string? FECHA_VENCIMIENTO_BASC { get; set; }

    [StringLength(255)]
    public string? NUMERO_FOLIOS { get; set; }

    [StringLength(255)]
    public string? MAIL_TEMPORALES { get; set; }

    [StringLength(255)]
    public string? NUMERO_AZ { get; set; }

    [StringLength(255)]
    public string? FECHA_INGRESO_ARCHIVO { get; set; }
}
