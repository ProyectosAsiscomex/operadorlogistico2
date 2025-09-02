using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class PlaneacionTransporte
{
    [StringLength(250)]
    [Unicode(false)]
    public string? EMPRESA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NIT { get; set; }

    [StringLength(100)]
    public string? TIPO { get; set; }

    [StringLength(100)]
    public string? ADUANA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    public string? MERCANCIA { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PEDIDO { get; set; }

    public string? PROVEEDOR { get; set; }

    public string? FACTURA { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DEPOSITO { get; set; }

    [StringLength(200)]
    public string? EMBARCADOR { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? TRANSPORTADOR { get; set; }

    [Column("TIPO CARGA")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TIPO_CARGA { get; set; }

    public string? CONTENEDORES { get; set; }

    [Column("PESO BRUTO", TypeName = "decimal(30, 6)")]
    public decimal? PESO_BRUTO { get; set; }

    [Column("PESO NETO", TypeName = "decimal(30, 6)")]
    public decimal? PESO_NETO { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? VOLUMEN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string ETA { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string ORIGINALES { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string LLEGADA { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string LIBERACION { get; set; } = null!;

    [Column("DOCUMENTOS AL TRANSPORTADOR")]
    [StringLength(30)]
    [Unicode(false)]
    public string DOCUMENTOS_AL_TRANSPORTADOR { get; set; } = null!;

    [Column("SOLICITUD ASIGNACION TRANSPORTE")]
    [StringLength(30)]
    [Unicode(false)]
    public string SOLICITUD_ASIGNACION_TRANSPORTE { get; set; } = null!;

    [Unicode(false)]
    public string? SITUACION { get; set; }
}
