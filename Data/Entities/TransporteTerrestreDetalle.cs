using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TransporteTerrestreDetalle")]
public partial class TransporteTerrestreDetalle
{
    [Key]
    public int idtransporteterrestredetalle { get; set; }

    public int? idtransporteterrestre { get; set; }

    public int? idtipocarga { get; set; }

    public int? idunidadcarga { get; set; }

    public int? idtamano { get; set; }

    public int? idtipoequipo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nrocontenedor { get; set; }

    public int? nrobultos { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? empaque { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobruto { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idunidadtransporte { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cedula { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? celular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? placas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? sellos { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidad { get; set; }

    public int? tara { get; set; }

    public int? idpedidodetalle { get; set; }

    public int? idtransportadordetalle { get; set; }
}
