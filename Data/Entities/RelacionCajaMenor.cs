using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RelacionCajaMenor")]
public partial class RelacionCajaMenor
{
    [Key]
    public int idRelacionCajaMenor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Identificacion { get; set; }

    public int? idPagado { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorBruto { get; set; }

    [Column(TypeName = "money")]
    public decimal? IVA { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteIva { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteFuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteCree { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorNeto { get; set; }

    [Unicode(false)]
    public string? Concepto { get; set; }
}
