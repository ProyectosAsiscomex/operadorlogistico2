using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class CostosLogistico
{
    public int? Id_Exportador { get; set; }

    [Column("RAZON SOCIAL")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RAZON_SOCIAL { get; set; }

    [StringLength(30)]
    public string? MES { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaFactura { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NEGOCIO { get; set; }

    [Column("TIPO DE PRODUCTO")]
    [Unicode(false)]
    public string? TIPO_DE_PRODUCTO { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MODALIDAD { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PEDIDO { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RESPONSABLE { get; set; }

    [Column("ADUANA DE EMBARQUE")]
    [StringLength(100)]
    public string? ADUANA_DE_EMBARQUE { get; set; }

    [Column("LUGAR DE EMBARQUE")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LUGAR_DE_EMBARQUE { get; set; }

    public string? Facturas { get; set; }

    [Column("TERMINO DE NEGOCIACION")]
    [StringLength(100)]
    public string? TERMINO_DE_NEGOCIACION { get; set; }

    [Column("VALOR FOB USD", TypeName = "decimal(38, 2)")]
    public decimal? VALOR_FOB_USD { get; set; }

    [Column("VALOR FLETE USD", TypeName = "decimal(38, 2)")]
    public decimal? VALOR_FLETE_USD { get; set; }

    [Column("VALOR SEGURO USD", TypeName = "decimal(38, 2)")]
    public decimal? VALOR_SEGURO_USD { get; set; }

    [Column("VALOR TOTAL USD", TypeName = "decimal(38, 2)")]
    public decimal? VALOR_TOTAL_USD { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? COMPRADOR { get; set; }

    [Column("PAIS DESTINO")]
    [StringLength(50)]
    public string? PAIS_DESTINO { get; set; }

    [Column("DESTINO FINAL")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DESTINO_FINAL { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NAVIERA { get; set; }

    [Column("TIPO CARGA")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TIPO_CARGA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TAMANO { get; set; }

    [Column("TIPO EQUIPO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TIPO_EQUIPO { get; set; }

    [Column("Unidad de Transporte")]
    public string? Unidad_de_Transporte { get; set; }

    [Column("CANT. UNIDAD DE CARGA")]
    public int? CANT__UNIDAD_DE_CARGA { get; set; }

    [Column("MERCANCIA PELIGROSA")]
    [StringLength(2)]
    [Unicode(false)]
    public string? MERCANCIA_PELIGROSA { get; set; }

    [Column("PESO NETO KG", TypeName = "decimal(38, 2)")]
    public decimal? PESO_NETO_KG { get; set; }

    [Column("PESO NETO TN", TypeName = "decimal(38, 6)")]
    public decimal? PESO_NETO_TN { get; set; }

    [Column("FECHA CARGUE PLANTA")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_CARGUE_PLANTA { get; set; }

    [Column("FECHA INGRESO A PUERTO")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_INGRESO_A_PUERTO { get; set; }

    [Column("FECHA DE ZARPE/CRUCE DE FRONTERA")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_DE_ZARPE_CRUCE_DE_FRONTERA { get; set; }

    [Column("DIAS EN PUERTO/FRONTERA")]
    public int? DIAS_EN_PUERTO_FRONTERA { get; set; }

    [Column("FLETE NACIONAL", TypeName = "money")]
    public decimal FLETE_NACIONAL { get; set; }

    [Column("MOVIMIENTO CONTENEDOR", TypeName = "money")]
    public decimal? MOVIMIENTO_CONTENEDOR { get; set; }

    [Column("USO DE INSTALACIONES", TypeName = "money")]
    public decimal? USO_DE_INSTALACIONES { get; set; }

    [Column("REGARGO CARGA PELIGROSA", TypeName = "money")]
    public decimal? REGARGO_CARGA_PELIGROSA { get; set; }

    [Column("CARGUE/DESCARGUE CAMION", TypeName = "money")]
    public decimal? CARGUE_DESCARGUE_CAMION { get; set; }

    [Column(TypeName = "money")]
    public decimal PESAJE { get; set; }

    [Column(TypeName = "money")]
    public decimal MOUNTING { get; set; }

    [Column("OPERADOR LOGISTICO INVIMA", TypeName = "money")]
    public decimal OPERADOR_LOGISTICO_INVIMA { get; set; }

    [Column("MOVILIZACION INSPECCION INVIMA", TypeName = "money")]
    public decimal MOVILIZACION_INSPECCION_INVIMA { get; set; }

    [Column(TypeName = "money")]
    public decimal? INVIMA { get; set; }

    [Column("COMISION ADUANA", TypeName = "money")]
    public decimal? COMISION_ADUANA { get; set; }

    [Column("TOTAL COSTOS NACIONALES", TypeName = "money")]
    public decimal? TOTAL_COSTOS_NACIONALES { get; set; }

    [Column("FLETE INTERNACIONAL", TypeName = "money")]
    public decimal? FLETE_INTERNACIONAL { get; set; }

    [Column("ALQUILER ISOTANQUES", TypeName = "money")]
    public decimal ALQUILER_ISOTANQUES { get; set; }

    [Column("DEVOLUCION DE ISOTANQUES", TypeName = "money")]
    public decimal DEVOLUCION_DE_ISOTANQUES { get; set; }

    [Column("TOTAL COSTOS INTERNACIONALES", TypeName = "money")]
    public decimal? TOTAL_COSTOS_INTERNACIONALES { get; set; }

    [Column("GASTOS EN PESOS", TypeName = "money")]
    public decimal? GASTOS_EN_PESOS { get; set; }

    [Column("Vr ( ($)/Kg ) 1", TypeName = "decimal(18, 4)")]
    public decimal? Vr_______Kg___1 { get; set; }

    [Column("(EN USD)", TypeName = "decimal(18, 4)")]
    public decimal? _EN_USD_ { get; set; }

    [Column("( Vr (USD)/Tn )", TypeName = "decimal(18, 4)")]
    public decimal? __Vr__USD__Tn__ { get; set; }

    [Column(TypeName = "money")]
    public decimal? ALMACENAMIENTO { get; set; }

    [Column("INSPECCION ANTINARCOTICOS", TypeName = "money")]
    public decimal? INSPECCION_ANTINARCOTICOS { get; set; }

    [Column("MOVILIZACION INSPECCION ANTINARCOTICOS ", TypeName = "money")]
    public decimal MOVILIZACION_INSPECCION_ANTINARCOTICOS_ { get; set; }

    [Column("OPERADOR LOGISTICO ANTINARCOTICOS", TypeName = "money")]
    public decimal OPERADOR_LOGISTICO_ANTINARCOTICOS { get; set; }

    [Column("SOBRE COSTOS VARIOS", TypeName = "money")]
    public decimal? SOBRE_COSTOS_VARIOS { get; set; }

    [Column("TOTAL SOBRECOSTOS", TypeName = "money")]
    public decimal? TOTAL_SOBRECOSTOS { get; set; }

    [Column("EN PESOS 2", TypeName = "money")]
    public decimal? EN_PESOS_2 { get; set; }

    [Column("Vr ($)/Kg ", TypeName = "decimal(18, 4)")]
    public decimal? Vr_____Kg_ { get; set; }

    [Column("En USD", TypeName = "decimal(18, 4)")]
    public decimal? En_USD { get; set; }

    [Column("Vr (USD)/Tn ", TypeName = "decimal(18, 4)")]
    public decimal? Vr__USD__Tn_ { get; set; }

    [Column("(%) Porcentaje del Costo Logístico sobre el Valor de la Mercancia")]
    public int? ____Porcentaje_del_Costo_Logístico_sobre_el_Valor_de_la_Mercancia { get; set; }
}
