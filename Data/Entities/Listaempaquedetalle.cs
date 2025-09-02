using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Listaempaquedetalle")]
public partial class Listaempaquedetalle
{
    [Key]
    public int idlistaempaqueitem { get; set; }

    public int? idlistaempaque { get; set; }

    [StringLength(50)]
    public string? Nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechafactura { get; set; }

    public int? idfactura { get; set; }

    public int? idproducto { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }

    [StringLength(500)]
    public string? Descripcion { get; set; }

    public int? idsubpartida { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? volumen { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? alto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? ancho { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? largo { get; set; }

    [StringLength(50)]
    public string? dimensiones { get; set; }

    [Column(TypeName = "money")]
    public decimal? precio { get; set; }

    [Column(TypeName = "money")]
    public decimal? subtotal { get; set; }

    public int? idunidad { get; set; }

    [StringLength(50)]
    public string? empaque { get; set; }

    [StringLength(50)]
    public string? nrolote { get; set; }

    [StringLength(50)]
    public string? nrocontenedor { get; set; }

    [StringLength(500)]
    public string? observaciones { get; set; }

    public int? idfacturaexpoitem { get; set; }
}
