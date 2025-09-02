using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("programadordetallecontenedor")]
public partial class programadordetallecontenedor
{
    [Key]
    public int idprogramadordetallecontenedor { get; set; }

    public int? iddo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nrocontenedor { get; set; }

    public int? idtipocarga { get; set; }

    public int? idunidadcarga { get; set; }

    public int? idtamanocontenedor { get; set; }

    public int? idtipoequipo { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidad { get; set; }

    public int? bultos { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? empaque { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobruto { get; set; }

    public bool? inspeccion { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? volumen { get; set; }
}
