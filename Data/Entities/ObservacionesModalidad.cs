using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ObservacionesModalidad")]
public partial class ObservacionesModalidad
{
    [Key]
    public int idObservacionMod { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? AplicaAranGeneral { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? AplicaIVAGeneral { get; set; }

    public bool? Estado { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? IgnoralAranGeneral { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? IgnoraIVAGeneral { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaHora { get; set; }
}
