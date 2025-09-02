using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("Cxp67")]
public partial class Cxp67
{
    [StringLength(255)]
    public string? Do { get; set; }

    public double? nit { get; set; }

    [StringLength(255)]
    public string? factura { get; set; }

    [StringLength(255)]
    public string? fecha_a { get; set; }

    [StringLength(255)]
    public string? vence { get; set; }

    [StringLength(255)]
    public string? nota { get; set; }

    [StringLength(255)]
    public string? nom_usu { get; set; }

    [StringLength(255)]
    public string? fecha_b { get; set; }

    public double? item { get; set; }

    public double? valor_br { get; set; }

    public double? iva { get; set; }

    public double? retefuente { get; set; }

    public double? reteica { get; set; }

    public double? reteiva { get; set; }

    public double? neto { get; set; }

    public int? iddo { get; set; }

    public int? idtercero { get; set; }

    public int? idgasto { get; set; }

    public int? idusuario { get; set; }

    public bool? repetida { get; set; }

    [StringLength(100)]
    public string? nrodo { get; set; }

    public bool? malo { get; set; }

    public int? idimportador { get; set; }

    public int? idcausacion { get; set; }
}
