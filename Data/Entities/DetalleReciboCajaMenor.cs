using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleReciboCajaMenor")]
public partial class DetalleReciboCajaMenor
{
    [Key]
    public int idDetalleReciboCajaMenor { get; set; }

    public int? idReciboCajaMenor { get; set; }

    public int? idGasto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroFactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaFactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorBruto { get; set; }

    [Column(TypeName = "decimal(17, 2)")]
    public decimal? PorcenIva { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorIva { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteIva { get; set; }

    [Column(TypeName = "decimal(17, 2)")]
    public decimal? PorcenReteFuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorRetencion { get; set; }

    [Column(TypeName = "decimal(17, 2)")]
    public decimal? PorcenReteIca { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorReteIca { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorNeto { get; set; }

    [ForeignKey("idGasto")]
    [InverseProperty("DetalleReciboCajaMenors")]
    public virtual Gasto? idGastoNavigation { get; set; }

    [ForeignKey("idReciboCajaMenor")]
    [InverseProperty("DetalleReciboCajaMenors")]
    public virtual ReciboCajaMenor? idReciboCajaMenorNavigation { get; set; }
}
