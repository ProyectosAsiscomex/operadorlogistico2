using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[PrimaryKey("IdRegistroItem", "IdRegistro")]
[Table("tbRegistrosItem")]
public partial class tbRegistrosItem
{
    [Key]
    public int IdRegistroItem { get; set; }

    [Key]
    public int IdRegistro { get; set; }

    public int? Item { get; set; }

    public int? idInsumo { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Cantidad { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Peso { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? ValorUnitario { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nCantidadDeclarada { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? sticker { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechasticker { get; set; }

    [StringLength(1000)]
    public string? descdeclaracion { get; set; }

    public int? idordendecompraitem { get; set; }

    public int? iddespacho { get; set; }
}
