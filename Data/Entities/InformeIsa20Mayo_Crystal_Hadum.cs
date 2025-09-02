using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class InformeIsa20Mayo_Crystal_Hadum
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Empresa { get; set; }

    [Column("D.O.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? D_O_ { get; set; }

    [Column("Fecha Creacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string Fecha_Creacion { get; set; } = null!;

    [Column(TypeName = "decimal(38, 15)")]
    public decimal? ValorFactura { get; set; }

    [Column("Inspeccion Antinarcoticos")]
    [StringLength(30)]
    [Unicode(false)]
    public string Inspeccion_Antinarcoticos { get; set; } = null!;

    [Column("Fecha Real Embarque")]
    [StringLength(30)]
    [Unicode(false)]
    public string Fecha_Real_Embarque { get; set; } = null!;
}
