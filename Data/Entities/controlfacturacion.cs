using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("controlfacturacion")]
public partial class controlfacturacion
{
    [Key]
    public int idcontrolfacturacion { get; set; }

    public int? idmoneda { get; set; }

    [StringLength(50)]
    public string? facturar { get; set; }

    [StringLength(50)]
    public string? nrodo { get; set; }

    [StringLength(50)]
    public string? pedidonro { get; set; }

    [StringLength(50)]
    public string? guiabl { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valoraduanausd { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? tasa { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? trm { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valoraduanacop { get; set; }

    [StringLength(50)]
    public string? observaciones { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? subtotalterc { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? subtotalprop { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? totalanticipos { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorfactura { get; set; }

    public int? idcliente { get; set; }

    public int? idimportador { get; set; }
}
