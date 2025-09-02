using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TempoCxP2")]
public partial class TempoCxP2
{
    [StringLength(255)]
    public string? prefijo { get; set; }

    public double? nit { get; set; }

    [StringLength(255)]
    public string? cnomb { get; set; }

    public double? dias { get; set; }

    [StringLength(255)]
    public string? fecha { get; set; }

    [StringLength(255)]
    public string? vence { get; set; }

    [StringLength(255)]
    public string? factura { get; set; }

    public double? valor_br { get; set; }

    public double? iva { get; set; }

    public double? reteiva { get; set; }

    public double? retefuente { get; set; }

    public double? retecree { get; set; }

    public double? neto { get; set; }

    public double? descuento { get; set; }

    [StringLength(255)]
    public string? d_o { get; set; }

    public int? idtercero { get; set; }

    public int? iddo { get; set; }

    [Column("do")]
    [StringLength(50)]
    public string? _do { get; set; }

    public int? idimportador { get; set; }
}
