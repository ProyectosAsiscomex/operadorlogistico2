using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class InformeIsa20Mayo_Crystal_Hada_Impo
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Importador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Cliente { get; set; } = null!;

    [Column("D.O.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? D_O_ { get; set; }

    [Column("Fecha Creacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Creacion { get; set; }

    [Column("Llegada Real")]
    [StringLength(30)]
    [Unicode(false)]
    public string Llegada_Real { get; set; } = null!;

    [Column("Fecha Entrega")]
    [StringLength(30)]
    [Unicode(false)]
    public string Fecha_Entrega { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Inspeccion { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Levante { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Despacho { get; set; } = null!;

    [Column("Fecha Aceptacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Aceptacion { get; set; }
}
