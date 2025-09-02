using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("causacionesitemsanticipo")]
public partial class causacionesitemsanticipo
{
    [Key]
    public int idcausacionitemsxanticipo { get; set; }

    public int? idcausacionencabezado { get; set; }

    public int? idcausacion { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valor { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? poriva { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valoriva { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porretefuente { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorretefuente { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorretencion { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porretecree { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorretecree { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorreteica { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorneto { get; set; }

    [Column(TypeName = "decimal(17, 2)")]
    public decimal? PorcenReteIca { get; set; }

    public bool? control { get; set; }

    public bool? control2 { get; set; }
}
