using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("migracionotek")]
public partial class migracionotek
{
    [StringLength(500)]
    public string? codigo { get; set; }

    public string? descripcion { get; set; }

    [StringLength(100)]
    public string? cip { get; set; }

    [StringLength(20)]
    public string? pa { get; set; }

    [StringLength(100)]
    public string? ucomercial { get; set; }

    [StringLength(100)]
    public string? programa { get; set; }

    [StringLength(100)]
    public string? tipo { get; set; }

    [StringLength(200)]
    public string? activo { get; set; }

    [StringLength(200)]
    public string? aplicapv { get; set; }

    public int? idSubpartida { get; set; }

    public int? idunidad { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? van { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? vie { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? vrfobcip { get; set; }

    public int? idproducto { get; set; }
}
