using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("facturaexpo")]
public partial class facturaexpo
{
    [Key]
    public int idfactura { get; set; }

    public int? idexportador { get; set; }

    public int? iddo { get; set; }

    [StringLength(50)]
    public string? ordendecompra { get; set; }

    [StringLength(50)]
    public string? auxiliar { get; set; }

    [StringLength(50)]
    public string? factura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechavencimiento { get; set; }

    public int? idcomprador { get; set; }

    public int? idconsignatario { get; set; }

    public int? idmoneda { get; set; }

    public int? idtrm { get; set; }

    public int? idincoterm { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? flete { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobruto { get; set; }

    public int? idpuertoembarque { get; set; }

    public int? cmbidpuertoembarque { get; set; }

    public int? iddestino { get; set; }

    public int? cmbiddestino { get; set; }

    public int? idvia { get; set; }

    public int? cmbidpais { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nroempaques { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? total { get; set; }

    public int? idpedido { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? condicionespago { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? listaempaque { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? totaltermino { get; set; }

    public bool? revisado { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? TasaCambio { get; set; }
}
