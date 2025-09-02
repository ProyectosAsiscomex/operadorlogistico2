using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ordendecompradetalle")]
public partial class ordendecompradetalle
{
    [Key]
    public int idordendecompradetalle { get; set; }

    public int? idordendecompra { get; set; }

    public int? idproductoimpo { get; set; }

    public int? idsubpartida { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vrunitariousd { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vrtotalusd { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vrunitariootramoneda { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vrtotalotramoneda { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidadoc { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidaddespachada { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidaddocumentotransporte { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidadnacionalizada { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidadandinadelvalor { get; set; }

    public int? idunidaddian { get; set; }

    public int? nrocajas { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesoreal { get; set; }

    public int? idordendecompraitem { get; set; }

    public int? idfacturaimpoitem { get; set; }

    public int? iddocumentotransporteitem { get; set; }

    public int? iddeclaracionimportacion { get; set; }

    public int? idandinavaloritem { get; set; }

    public int? idregistroimpoitem { get; set; }

    [StringLength(10)]
    public string? iddespachoitem { get; set; }

    public bool? sistemasespeciales { get; set; }

    public bool? muestrassinvalor { get; set; }

    public bool? registro { get; set; }

    public int? idmodalidad { get; set; }
}
