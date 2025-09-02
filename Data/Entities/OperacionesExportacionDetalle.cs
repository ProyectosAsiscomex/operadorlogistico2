using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class OperacionesExportacionDetalle
{
    public int idautorizacionembarque { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Formulario { get; set; }

    public int? Grupo { get; set; }

    public short? Serie { get; set; }

    [StringLength(20)]
    public string? Subpartida { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo_Unidad_Fisica { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Cantidad_Unidad_Fisica { get; set; }

    [StringLength(50)]
    public string? Unidad_Comercial { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Cantidad_Unidad_Comercial { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Embalaje { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Nro_Bultos { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Peso_Neto { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Valor_FOB { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Marcas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Do { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Creacion { get; set; }

    public int? Sede_Comercializadora { get; set; }

    [StringLength(803)]
    public string? Asesor_Comercial { get; set; }

    [StringLength(803)]
    public string? Asesor_Operativo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Referencia_DO { get; set; }

    public string? Observaciones_DO { get; set; }

    [StringLength(200)]
    public string? Estado { get; set; }

    [StringLength(100)]
    public string? Nro_Factura { get; set; }

    public bool? Mcia_Peligrosa { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Exportador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Declarante { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Destinatario { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Formulario_Anterior { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Referencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Autorizacion_Global { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Programa_MSVC { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Regimen_Aduanero { get; set; }

    [StringLength(100)]
    public string? Aduana_Despacho { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Region_Procedencia { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Embarque { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Datos { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Naturaleza_Transaccion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Solicitud { get; set; }

    [StringLength(100)]
    public string? Incoterm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Lugar_Entrega { get; set; }

    [StringLength(100)]
    public string? Moneda { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Valor_Factura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tasa_Cambio { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Forma_Pago { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cantidad_Pagos_Anticipados { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Primer_Pago_Anticipado { get; set; }

    public bool? Mcia_Manos_Viajero { get; set; }

    public bool? Sistemas_Especiales { get; set; }

    public bool? Exportacion_Transito { get; set; }

    public bool? Mcia_Zona_Primaria { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_Transporte { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Carga { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Viaje { get; set; }

    [StringLength(100)]
    public string? Aduana_Salida { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Lugar_Embarque { get; set; }

    [StringLength(50)]
    public string? Pais { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Lugar_Destino { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Zona_Franca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Deposito_Habilitado { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Transportador { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Lugar_Inspeccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Aprobacion_Inspeccion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Direccion_Ubicacion_Mcia { get; set; }

    public bool? Solicita_Inspeccion_Fisica { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Total_Fletes { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Total_Seguros { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Total_Otros_Gastos { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Total_Valor_Reintegrar { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Radicado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sede_Operativa { get; set; }

    public int? Nro_Envio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha_Creacion_SAE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Ultima_Modificacion_SAE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Dex_Definitivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Dex_Definitivo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_De_Operacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? estadoSAE { get; set; }

    [StringLength(803)]
    public string? Usuario_Digitador { get; set; }

    [StringLength(803)]
    public string? Usuario_Revisor { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Aceptacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Origen_SAE { get; set; }

    [StringLength(100)]
    public string? Sede_Digitadora { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Autorizacion { get; set; }

    [StringLength(50)]
    public string? Dex_Provisional { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Dex_Provisional { get; set; }
}
