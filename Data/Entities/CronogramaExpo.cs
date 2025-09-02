using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class CronogramaExpo
{
    [Column("Numero Do")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Numero_Do { get; set; }

    [Column("Fecha Creacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Creacion { get; set; }

    [StringLength(803)]
    public string? Auxiliar { get; set; }

    [StringLength(803)]
    public string? Tramitador { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Empresa { get; set; }

    public string Pedido { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? Importador { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string Deposito { get; set; } = null!;

    [Column("Motonave/Aerol")]
    [StringLength(200)]
    [Unicode(false)]
    public string Motonave_Aerol { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Sucursal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Ciudad { get; set; }

    [Column("Fecha ETA")]
    [StringLength(36)]
    public string Fecha_ETA { get; set; } = null!;

    [Column("Fecha ETD")]
    [StringLength(36)]
    public string Fecha_ETD { get; set; } = null!;

    [Column("Fecha Originales")]
    [StringLength(36)]
    public string Fecha_Originales { get; set; } = null!;

    [Column("Fecha Sol Anticipos")]
    [StringLength(36)]
    public string Fecha_Sol_Anticipos { get; set; } = null!;

    [Column("Fecha Rbo Anticipos")]
    [StringLength(36)]
    public string Fecha_Rbo_Anticipos { get; set; } = null!;

    [Column("Fecha Rad Planilla Ingreso Transporte")]
    [StringLength(36)]
    public string Fecha_Rad_Planilla_Ingreso_Transporte { get; set; } = null!;

    [Column("Fecha Ingreso Deposito")]
    [StringLength(36)]
    public string Fecha_Ingreso_Deposito { get; set; } = null!;

    [Column("Fecha Solicitud inspeccion Antinarcoticos")]
    [StringLength(36)]
    public string Fecha_Solicitud_inspeccion_Antinarcoticos { get; set; } = null!;

    [Column("Fecha Selectividad Antinarcotico")]
    [StringLength(36)]
    public string Fecha_Selectividad_Antinarcotico { get; set; } = null!;

    [StringLength(200)]
    public string? Estado { get; set; }

    [Column("Fecha Inpeccion Antinarcoticos")]
    [StringLength(36)]
    public string Fecha_Inpeccion_Antinarcoticos { get; set; } = null!;

    [Column("Fecha Solicitud Autorizacion Embarque")]
    [StringLength(50)]
    [Unicode(false)]
    public string Fecha_Solicitud_Autorizacion_Embarque { get; set; } = null!;

    [Column("Fecha Selectividad Aduanera", TypeName = "datetime")]
    public DateTime Fecha_Selectividad_Aduanera { get; set; }

    [Column("Fecha Inpeccion Aduanera")]
    [StringLength(36)]
    public string Fecha_Inpeccion_Aduanera { get; set; } = null!;

    [Column("Fecha Autorizacion Embarque")]
    [StringLength(36)]
    public string Fecha_Autorizacion_Embarque { get; set; } = null!;

    [Column("Fecha Radicacion Documento Deposito")]
    [StringLength(36)]
    public string Fecha_Radicacion_Documento_Deposito { get; set; } = null!;

    [Column("Fecha Bodegajes pagados hasta")]
    [StringLength(36)]
    public string Fecha_Bodegajes_pagados_hasta { get; set; } = null!;

    [Column("Fecha Embarque Real")]
    [StringLength(36)]
    public string Fecha_Embarque_Real { get; set; } = null!;

    [Column("Fecha Facturado")]
    [StringLength(30)]
    [Unicode(false)]
    public string Fecha_Facturado { get; set; } = null!;

    [Column("DEX No")]
    public string DEX_No { get; set; } = null!;

    [Column("FECHA DEX")]
    public string FECHA_DEX { get; set; } = null!;

    [Column("Fecha Devolucion DEX Cliente")]
    [StringLength(36)]
    public string Fecha_Devolucion_DEX_Cliente { get; set; } = null!;

    [Unicode(false)]
    public string? Observaciones { get; set; }
}
