using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class sistemasespeciale
{
    [Key]
    public int idsistemaespecial { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroprograma { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? reposicion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrocip { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroproducto { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? cantidadprodexpocip { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? van { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? vie { get; set; }

    public int? iddatosserie { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? ValorFOB { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? valorfobcip { get; set; }
}
