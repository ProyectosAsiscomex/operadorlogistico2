using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Fact_PendientexFacturarImpo
{
    [StringLength(200)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [Column("D.O. No.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? D_O__No_ { get; set; }

    [Column("Dias Entregados")]
    public int? Dias_Entregados { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Anticipos { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Despacho { get; set; } = null!;

    [Column("Días de Despacho")]
    public int? Días_de_Despacho { get; set; }

    [Column("Días de Rad. Facturación")]
    [StringLength(30)]
    [Unicode(false)]
    public string Días_de_Rad__Facturación { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Bodegajes { get; set; } = null!;
}
