using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("productosimpo")]
public partial class productosimpo
{
    [Key]
    public int idproductoimpo { get; set; }

    public int? idimportador { get; set; }

    public int? exportador { get; set; }

    public bool? habilitado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? codigo { get; set; }

    public int? idarancel { get; set; }

    public int? unidad { get; set; }

    [Unicode(false)]
    public string? nombrecomercial { get; set; }

    [Unicode(false)]
    public string? otrascaracteristicas { get; set; }

    [Unicode(false)]
    public string? observaciones { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? peso { get; set; }

    [StringLength(5)]
    public string? ci { get; set; }

    [Column(TypeName = "decimal(14, 5)")]
    public decimal? arancel { get; set; }

    [Column(TypeName = "decimal(14, 5)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "decimal(12, 7)")]
    public decimal? factor { get; set; }

    [StringLength(200)]
    public string? marca { get; set; }

    [StringLength(50)]
    public string? anofabricacion { get; set; }

    [StringLength(300)]
    public string? tipomerca { get; set; }

    [StringLength(300)]
    public string? modelo { get; set; }

    [StringLength(500)]
    public string? clase { get; set; }

    [StringLength(150)]
    public string? referencia { get; set; }

    public string? DescMinimasMincomex { get; set; }

    [StringLength(10)]
    public string? posiciontempo { get; set; }

    [StringLength(10)]
    public string? unidadtempo { get; set; }

    [StringLength(10)]
    public string? codciatempo { get; set; }

    [StringLength(1000)]
    public string? descinicial_dim { get; set; }

    public string? descfinal_dim { get; set; }

    [StringLength(1000)]
    public string? descinicial_reg { get; set; }

    [StringLength(1000)]
    public string? descfinal_reg { get; set; }

    [StringLength(200)]
    public string? alertaproducto { get; set; }

    [Unicode(false)]
    public string? bd { get; set; }
}
