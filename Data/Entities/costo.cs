using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class costo
{
    [StringLength(50)]
    public string? factura { get; set; }

    [Column("do")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _do { get; set; }

    [StringLength(100)]
    public string? tipodo { get; set; }

    [StringLength(200)]
    public string? costoconcepto { get; set; }

    [Column("costo", TypeName = "decimal(38, 6)")]
    public decimal? costo1 { get; set; }

    [Column("Razon Social")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Razon_Social { get; set; }

    public int? fechafact { get; set; }
}
