using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Devolucion_Cliente
{
    public int? idimportador { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [StringLength(100)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? valorneto { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? valorbruto { get; set; }

    [Column(TypeName = "money")]
    public decimal? ivapropios { get; set; }

    [Column(TypeName = "money")]
    public decimal? retefuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva { get; set; }

    public int? idfactura { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string estado { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal reteica { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string nrodo { get; set; } = null!;
}
