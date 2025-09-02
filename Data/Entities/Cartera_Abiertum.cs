using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Cartera_Abiertum
{
    public int idfactura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    public int? idimportador { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    [StringLength(50)]
    public string? Nrofactura { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Empresa { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? FacturasinIva { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? FacturaconIva { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? ValorBruto { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? ValorNeto { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? saldo { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal IngresosPropios { get; set; }

    [Column(TypeName = "money")]
    public decimal? Abonos { get; set; }

    [Column(TypeName = "decimal(38, 10)")]
    public decimal IVAPropios { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal Terceros { get; set; }

    [Column(TypeName = "money")]
    public decimal Anticipos { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteIVA { get; set; }

    [Column(TypeName = "money")]
    public decimal ReteFuente { get; set; }

    [Column(TypeName = "money")]
    public decimal ReteICA { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal TASACAMBIO { get; set; }
}
