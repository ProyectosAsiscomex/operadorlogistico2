using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class documentotransportedetallemercancia
{
    [Key]
    public int idbldetallemercancias { get; set; }

    public int? idbl { get; set; }

    [StringLength(700)]
    [Unicode(false)]
    public string? descripcionmercancia { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? cantidad { get; set; }

    public int? idunidaddianmercancia { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesobruto { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? observacionesmercancia { get; set; }

    public int? idordendecompra { get; set; }

    public int? idfactura { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? pedido { get; set; }

    public int? idsubpartida { get; set; }

    public int? iddetallefacturaimportacion { get; set; }

    public int? idDo { get; set; }
}
