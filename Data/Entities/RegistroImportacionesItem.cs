using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RegistroImportacionesItem")]
public partial class RegistroImportacionesItem
{
    [Key]
    public int idRegistroItem { get; set; }

    public int? idRegistroImportacion { get; set; }

    public int? idunidad { get; set; }

    public int? idarancel { get; set; }

    public int? idinsumo { get; set; }

    [StringLength(3000)]
    public string? descripcion { get; set; }

    public string? descripcionminima { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? valor { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesoneto { get; set; }

    public int? idvistobuenoitem { get; set; }

    public int? idordendecompraItem { get; set; }

    public int? idproductoimpo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? aplicaMaterialCKD { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? AnoFabricacionvehiculo { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Anomodelovehiculo { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Anofabricacionitem { get; set; }

    public int? iddetallefacturaimportacion { get; set; }
}
