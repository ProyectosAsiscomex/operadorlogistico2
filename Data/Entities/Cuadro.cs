using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Cuadro
{
    [Key]
    public int idcuadro { get; set; }

    [StringLength(50)]
    public string? cuadro { get; set; }

    [StringLength(50)]
    public string? nitimpo { get; set; }

    [StringLength(50)]
    public string? nitexpo { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? pesoprod { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobcip { get; set; }

    [StringLength(50)]
    public string? posicion { get; set; }

    [StringLength(400)]
    public string? producto { get; set; }

    [StringLength(200)]
    public string? unidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fechapresentacion { get; set; }

    [StringLength(50)]
    public string? programa { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? porvan { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? porvie { get; set; }
}
