using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CuadrosItem")]
public partial class CuadrosItem
{
    [Key]
    public int idcuadroitem { get; set; }

    public int? idcuadro { get; set; }

    [StringLength(50)]
    public string? ci { get; set; }

    [StringLength(1000)]
    public string? insumo { get; set; }

    [StringLength(50)]
    public string? posicion { get; set; }

    [StringLength(50)]
    public string? unidad { get; set; }

    [Column(TypeName = "decimal(18, 7)")]
    public decimal? consumo { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfob { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? residuo { get; set; }

    [StringLength(50)]
    public string? destino { get; set; }
}
