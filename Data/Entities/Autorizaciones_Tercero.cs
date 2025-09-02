using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Autorizaciones_Tercero
{
    [StringLength(100)]
    public string? cNombre { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactrua { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? vence { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorbruto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? reteica { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteFuente { get; set; }

    public string? observaciones { get; set; }
}
