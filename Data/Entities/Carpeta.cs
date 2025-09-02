using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Carpeta
{
    [Key]
    public int idcarpeta { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ffinimpo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ffinexpo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fpres { get; set; }

    [Column(TypeName = "money")]
    public decimal? cupo { get; set; }

    public int? idimportador { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? modalidad { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idvinculo { get; set; }

    public bool? bloqueado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecficom { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechpres { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecfinexp { get; set; }

    [StringLength(100)]
    public string? controlar { get; set; }

    public bool? protegido { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechatermino { get; set; }
}
