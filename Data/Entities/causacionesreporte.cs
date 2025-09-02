using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class causacionesreporte
{
    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    [StringLength(100)]
    public string? PROVEEDOR { get; set; }

    [Column("NO FACTURA")]
    [StringLength(200)]
    [Unicode(false)]
    public string? NO_FACTURA { get; set; }

    [Column("NRO CAUSACION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NRO_CAUSACION { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? CLIENTE { get; set; }

    [Column("FECHA FACTURA", TypeName = "smalldatetime")]
    public DateTime? FECHA_FACTURA { get; set; }

    [Column("FECHA CAUSACION", TypeName = "smalldatetime")]
    public DateTime? FECHA_CAUSACION { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ESTADO { get; set; } = null!;
}
