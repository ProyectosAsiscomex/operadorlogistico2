using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("pedidodecompraitem")]
public partial class pedidodecompraitem
{
    [Key]
    public int idpedidodecompraitem { get; set; }

    public int? idpedido { get; set; }

    public int? idProducto { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorunitario { get; set; }

    [Column(TypeName = "money")]
    public decimal? valormonedaneg { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadentregada { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadpendiente { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? pesoneto { get; set; }

    [StringLength(150)]
    public string? embalaje { get; set; }

    public int? idunidad { get; set; }

    public int? idsubpartida { get; set; }

    [Unicode(false)]
    public string? resumenproducto { get; set; }

    [Unicode(false)]
    public string? resumenposiciones { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? subtotal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Negocio { get; set; }
}
