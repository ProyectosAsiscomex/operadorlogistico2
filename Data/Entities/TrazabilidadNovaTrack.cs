using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class TrazabilidadNovaTrack
{
    [Column("D.O.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? D_O_ { get; set; }

    [StringLength(200)]
    public string? Estado { get; set; }

    [Column("Fecha Apertura", TypeName = "smalldatetime")]
    public DateTime? Fecha_Apertura { get; set; }

    [Column("Mes Apertura")]
    [StringLength(30)]
    public string? Mes_Apertura { get; set; }

    [StringLength(803)]
    public string? Auxiliar { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(1000)]
    public string Mercancia { get; set; } = null!;

    [Column("PARTIDA ARANCELARIA")]
    public string PARTIDA_ARANCELARIA { get; set; } = null!;

    [Column("Instrucción Especial")]
    [StringLength(1000)]
    public string? Instrucción_Especial { get; set; }

    [Column("No BL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? No_BL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Hijo { get; set; }

    [Column("Nro Poliza")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Poliza { get; set; }

    [StringLength(50)]
    public string Origen { get; set; } = null!;

    [StringLength(50)]
    public string Destino { get; set; } = null!;

    [StringLength(10)]
    public string Incoterm { get; set; } = null!;

    [Column("Agente Internacional en Origen")]
    [StringLength(200)]
    public string Agente_Internacional_en_Origen { get; set; } = null!;

    [Column("Agente Internacional en Destino")]
    [StringLength(200)]
    public string Agente_Internacional_en_Destino { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Seguro { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Carrier { get; set; } = null!;

    [StringLength(50)]
    public string POL { get; set; } = null!;

    [StringLength(50)]
    public string POD { get; set; } = null!;

    [Column("Luegar retiro contenedor")]
    [StringLength(1)]
    [Unicode(false)]
    public string Luegar_retiro_contenedor { get; set; } = null!;

    [Column("Peso (Kg)", TypeName = "decimal(18, 5)")]
    public decimal Peso__Kg_ { get; set; }

    [Column("Vol (m3)", TypeName = "decimal(18, 5)")]
    public decimal Vol__m3_ { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ETD { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ETA { get; set; }

    [Column("Fecha Radicacion", TypeName = "datetime")]
    public DateTime? Fecha_Radicacion { get; set; }

    [Column("Documentos para Aduana Completos", TypeName = "datetime")]
    public DateTime? Documentos_para_Aduana_Completos { get; set; }

    [Column("Fecha Traslado a Deposito", TypeName = "datetime")]
    public DateTime? Fecha_Traslado_a_Deposito { get; set; }

    [Column("Anticipos por el Cliente", TypeName = "datetime")]
    public DateTime? Anticipos_por_el_Cliente { get; set; }

    [Column("Valor Anticipo Aduana", TypeName = "money")]
    public decimal Valor_Anticipo_Aduana { get; set; }

    [Column("Pago Declaraciones", TypeName = "datetime")]
    public DateTime? Pago_Declaraciones { get; set; }

    [Column("Fecha Selectividad", TypeName = "datetime")]
    public DateTime? Fecha_Selectividad { get; set; }

    [Column("Fecha Levante", TypeName = "datetime")]
    public DateTime? Fecha_Levante { get; set; }

    [Column("Empresa de Transporte para Aduana")]
    [StringLength(1)]
    [Unicode(false)]
    public string Empresa_de_Transporte_para_Aduana { get; set; } = null!;

    [Column("Selectividad Automatica/Fisica")]
    [StringLength(1)]
    [Unicode(false)]
    public string Selectividad_Automatica_Fisica { get; set; } = null!;

    [Column("Solicitud Planilla Retiro", TypeName = "datetime")]
    public DateTime? Solicitud_Planilla_Retiro { get; set; }

    [Column("Notificación al Transporte", TypeName = "datetime")]
    public DateTime? Notificación_al_Transporte { get; set; }

    [Column("Total Ingresos", TypeName = "decimal(38, 6)")]
    public decimal? Total_Ingresos { get; set; }

    [Column("Ingresos Propios", TypeName = "decimal(38, 6)")]
    public decimal? Ingresos_Propios { get; set; }

    [Column("Ingresos Terceros", TypeName = "decimal(38, 6)")]
    public decimal? Ingresos_Terceros { get; set; }

    [Column("Causaciones Terceros", TypeName = "decimal(38, 2)")]
    public decimal? Causaciones_Terceros { get; set; }

    [Column("Causaciones Propios", TypeName = "decimal(38, 2)")]
    public decimal? Causaciones_Propios { get; set; }
}
