using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DEXItem")]
public partial class DEXItem
{
    [Key]
    public int IdDEXItem { get; set; }

    public int? IdDEX { get; set; }

    public int? IdDatosSerie { get; set; }

    public int? IdAutorizacionEmbarque { get; set; }

    public int? Item { get; set; }

    public int? IdSubpartida { get; set; }

    [StringLength(10)]
    public string? Subpartida { get; set; }

    [StringLength(2)]
    public string? CodigoRegionOrigen { get; set; }

    [StringLength(20)]
    public string? NumeroFactura { get; set; }

    [StringLength(2)]
    public string? CodigoUnidadComercial { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? CantidadUnidadComercial { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? PesoNeto { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? ValorFob { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? VAN { get; set; }

    public string? Descripciones { get; set; }

    [StringLength(6)]
    public string? CIP { get; set; }

    [StringLength(3)]
    public string? AplicacionCasilla66 { get; set; }
}
