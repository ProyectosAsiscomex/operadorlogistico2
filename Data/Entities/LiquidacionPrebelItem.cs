using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class LiquidacionPrebelItem
{
    public int? iddetallefacturaimportacion { get; set; }

    public int? idDO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sticker { get; set; }

    [Column("Referencia Interna")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Referencia_Interna { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Cantidad { get; set; }

    [Column("Orden de compra")]
    public string? Orden_de_compra { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? Precio { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroDO { get; set; }
}
