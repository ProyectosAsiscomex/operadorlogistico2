using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class documentotransportedetallecontenedore
{
    [Key]
    public int idbldetalle { get; set; }

    public int? idbl { get; set; }

    public int? idtamanocontenedor { get; set; }

    public int? idtipoequipo { get; set; }

    public int? idestadocontenedor { get; set; }

    public int? idordendecompra { get; set; }

    public int? idfactura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nocontenedores { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? tara { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? marcasnumeros { get; set; }

    [Column(TypeName = "decimal(30, 16)")]
    public decimal? flete { get; set; }

    public int? idtiponegociacion { get; set; }

    [StringLength(100)]
    public string? nrocomodato { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainiciodemoras { get; set; }

    [StringLength(1000)]
    public string? lugarentrega { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(400)]
    public string? ciudad { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharetirocarga { get; set; }

    public bool? desconsolidar { get; set; }

    [StringLength(500)]
    public string? estado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharetirocontenedor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    public int? idinstruccion { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? costodia { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? nrobultos { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? volumen { get; set; }

    [StringLength(500)]
    public string? lugardevolucionn { get; set; }

    public int? diaslibres { get; set; }
}
