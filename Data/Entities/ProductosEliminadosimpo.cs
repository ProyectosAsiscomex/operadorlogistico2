using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ProductosEliminadosimpo")]
public partial class ProductosEliminadosimpo
{
    [Key]
    public int idproductoeliminadoimpo { get; set; }

    public int? idproducto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombrecomercial { get; set; }

    public int? idarancel { get; set; }

    public int? idexportador { get; set; }

    public int? idUsuarioDigitator { get; set; }

    public int? idUsuarioModificador { get; set; }

    public int? idUsuarioEliminador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaModificacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaEliminacion { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? observacion { get; set; }
}
