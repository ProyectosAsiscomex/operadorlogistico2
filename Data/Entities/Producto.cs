using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Producto
{
    [Key]
    public int idproducto { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [Column(TypeName = "decimal(12, 7)")]
    public decimal? peso { get; set; }

    [Column(TypeName = "decimal(12, 7)")]
    public decimal? factor { get; set; }

    public int? idarancel { get; set; }

    public int? idunidad { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    public int? idexportador { get; set; }

    [StringLength(300)]
    public string? nombrecomercial { get; set; }

    public int? idUsuarioDigitator { get; set; }

    public int? idUsuarioModifica { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaModificacion { get; set; }

    public bool? estado { get; set; }
}
