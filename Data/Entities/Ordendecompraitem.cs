using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Ordendecompraitem")]
public partial class Ordendecompraitem
{
    [Key]
    public int idordendecompraitem { get; set; }

    public long? idorden { get; set; }

    public long? idinsumo { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorunitario { get; set; }

    [Column(TypeName = "money")]
    public decimal? valormonedaneg { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadentregada { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadpendiente { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadconfirmada { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorunitarioconfirmado { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidaddespachada { get; set; }

    public int? idvia { get; set; }

    public bool? zonafranca { get; set; }

    [StringLength(50)]
    public string? calificacionabc { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadInicial { get; set; }

    public int? idbodega { get; set; }

    [StringLength(250)]
    public string? observacionesdetalle { get; set; }

    public int? idcategoria { get; set; }

    public int? idlugardestino { get; set; }
}
