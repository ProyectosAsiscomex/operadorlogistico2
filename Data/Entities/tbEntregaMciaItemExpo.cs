using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[PrimaryKey("idPedido", "idPedidodecompraitem", "idEntrega", "idEntregaItem")]
[Table("tbEntregaMciaItemExpo")]
public partial class tbEntregaMciaItemExpo
{
    [Key]
    public int idPedido { get; set; }

    [Key]
    public int idPedidodecompraitem { get; set; }

    [Key]
    public int idEntrega { get; set; }

    [Key]
    public int idEntregaItem { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nCantidadEntregada { get; set; }
}
