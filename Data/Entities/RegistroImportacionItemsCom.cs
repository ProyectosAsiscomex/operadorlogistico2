using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RegistroImportacionItemsCom")]
public partial class RegistroImportacionItemsCom
{
    [Key]
    public int iddetalleRegistrocomplemento { get; set; }

    public int? idregistroimpo { get; set; }

    public int? idvistobueno { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? codgasto { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorgasto { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? descripgasto { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? coddescuento { get; set; }

    [Column(TypeName = "money")]
    public decimal? valordescuento { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? descdescuento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? descripvb { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? codvb { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaExpedicion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Referencia { get; set; }
}
