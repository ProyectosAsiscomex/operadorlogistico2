using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DespachoExport")]
public partial class DespachoExport
{
    [Key]
    public int iddespacho { get; set; }

    [StringLength(50)]
    public string? auxiliar { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadespacho { get; set; }

    public int? idorden { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? orden { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fechaorden { get; set; }

    public int? idfacturaexpoitem { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? cantidadenvio { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? cantidaddespachada { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? cantidadpendiente { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? cantidadcajas { get; set; }

    public int? tipodespacho { get; set; }

    public bool? estado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaentrega { get; set; }

    public int? idvia { get; set; }

    [StringLength(10)]
    public string? cantidadsolicitada { get; set; }

    [StringLength(50)]
    public string? licencia { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? despachosparciales { get; set; }

    public bool? licenciaaprobada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaaprobacionlicencia { get; set; }

    public bool? subpartidaaprobada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechasubpartidaaprobada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechatraducciondescripcion { get; set; }

    public int? idPuertoCargue { get; set; }

    public int? idlugarembarque { get; set; }

    public int? idlugardestino { get; set; }

    public int? idaduana { get; set; }

    public int? idfactexpo { get; set; }
}
