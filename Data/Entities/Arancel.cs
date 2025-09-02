using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Arancel")]
public partial class Arancel
{
    [Key]
    public int idarancel { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? posicion { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? descripcion { get; set; }

    public int? idunidad { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? arancel { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? iva { get; set; }

    [StringLength(1000)]
    public string? descripcioncertificado { get; set; }

    [StringLength(20)]
    public string? naladisa { get; set; }

    [StringLength(20)]
    public string? nabalalc { get; set; }

    public bool? bloqueado { get; set; }
}
