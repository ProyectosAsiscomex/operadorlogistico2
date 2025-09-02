using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ItemsTarifario")]
public partial class ItemsTarifario
{
    [Key]
    public int Id { get; set; }

    public int? IdTarifarioItem { get; set; }

    public int? IdConcepto { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Cantidad { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Tarifa { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdMoneda { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Tasa { get; set; }

    [Unicode(false)]
    public string? Tipo { get; set; }

    [Unicode(false)]
    public string? TipoGasto { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TarifaMinima { get; set; }

    [Unicode(false)]
    public string? RutaContenedor { get; set; }

    public double? Porcentaje { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }

    public int? IdPuertoOrigen { get; set; }

    public int? IdPuertoDestino { get; set; }

    public int? IdTarifaMasterItem { get; set; }

    public int? IdTamanioContenedor { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalTarifa { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PesoCargable { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TarifaCompra { get; set; }
}
