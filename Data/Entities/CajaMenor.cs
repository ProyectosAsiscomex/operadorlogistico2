using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CajaMenor")]
public partial class CajaMenor
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Identificacion { get; set; }

    [StringLength(200)]
    public string? Pagado { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ValorBruto { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Iva { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ReteIva { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ReteCree { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ValorNeto { get; set; }

    [StringLength(2000)]
    public string? Concepto { get; set; }
}
