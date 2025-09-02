using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Cronograma
{
    [StringLength(10)]
    [Unicode(false)]
    public string? horaanticipo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechaanticipo { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? totalanticipo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? horasolanticipo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechasolanticipo { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? anticiposolicitado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FECHACREACION { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EMPRESA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NIT { get; set; }

    [StringLength(100)]
    public string? TIPO { get; set; }

    [Column("ADUANA LLEGADA")]
    [StringLength(100)]
    public string? ADUANA_LLEGADA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SUCURSAL { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CIUDAD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    [Column("Transportador Nacional")]
    [StringLength(1)]
    [Unicode(false)]
    public string Transportador_Nacional { get; set; } = null!;

    public string Pedido { get; set; } = null!;

    public string? PROVEEDOR { get; set; }

    public string? FACTURA { get; set; }

    [StringLength(601)]
    public string? DEPOSITO { get; set; }

    [StringLength(200)]
    public string? EMBARCADOR { get; set; }

    [Column("TRANS NACIONAL")]
    [StringLength(1)]
    [Unicode(false)]
    public string TRANS_NACIONAL { get; set; } = null!;

    [StringLength(803)]
    public string? AUXILIAR { get; set; }

    [StringLength(803)]
    public string? TRAMITADOR { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string ETA { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string LLEGADA { get; set; } = null!;

    [StringLength(62)]
    [Unicode(false)]
    public string? VENCIMIENTO { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string ORIGINALES { get; set; } = null!;

    [Column("SOL ANTICIPOS")]
    [StringLength(40)]
    [Unicode(false)]
    public string SOL_ANTICIPOS { get; set; } = null!;

    [Column("REC ANTICIPOS")]
    [StringLength(40)]
    [Unicode(false)]
    public string REC_ANTICIPOS { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string ACEPTACION { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string PAGO { get; set; } = null!;

    [StringLength(49)]
    [Unicode(false)]
    public string? SELECTIVIDAD { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string INSPECCION { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string LEVANTE { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string ENTREGA { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string DESPACHO { get; set; } = null!;

    [Column("FECHA LOCALIZACION", TypeName = "smalldatetime")]
    public DateTime FECHA_LOCALIZACION { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string LIBERACION { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string CUENTAFLETES { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string COMODATO { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string PAZYSALVO { get; set; } = null!;

    [Column("CONTROL FACTURA")]
    [StringLength(20)]
    public string? CONTROL_FACTURA { get; set; }

    [Unicode(false)]
    public string? SITUACION { get; set; }

    public string? OBSERVACIONES { get; set; }

    [Column("Tipo Carga")]
    public string? Tipo_Carga { get; set; }

    public string? INSTRUCCIONES { get; set; }

    public string? obtenidos { get; set; }

    public int PrioridadHaceb { get; set; }

    public long? OrdenEta { get; set; }

    public long? Ordenllegada { get; set; }
}
