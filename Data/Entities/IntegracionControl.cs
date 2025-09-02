using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("IntegracionControl")]
public partial class IntegracionControl
{
    [Column("do")]
    [StringLength(100)]
    [Unicode(false)]
    public string? _do { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaSolicitud { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaIntegracion { get; set; }

    [Unicode(false)]
    public string? Instruccion { get; set; }

    public int? orden { get; set; }
}
