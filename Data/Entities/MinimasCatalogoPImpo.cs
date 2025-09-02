using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("MinimasCatalogoPImpo")]
public partial class MinimasCatalogoPImpo
{
    [Key]
    public int idminimacatalogop { get; set; }

    public int idproducto { get; set; }

    public int? cod_desc { get; set; }

    public int? orden { get; set; }

    [StringLength(50)]
    public string? tipovalor { get; set; }

    public int? cod_desc_lst { get; set; }

    public int? cod_desc_val { get; set; }

    public long? v_num { get; set; }

    public string? v_alfa { get; set; }

    public int? v_num_otro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? v_otro { get; set; }

    public int? item { get; set; }

    public int? IDMINIMA1 { get; set; }

    public int? IDMINIMA2 { get; set; }

    public int? IDMINIMA { get; set; }

    public bool? MinimaCatalogo { get; set; }

    public bool? MinimaFactura { get; set; }

    public bool? MinimaRegistro { get; set; }

    public bool? DeclaImpo { get; set; }

    public bool? RegistroImpo { get; set; }

    public int? iddetallefacturaimportacion { get; set; }

    public int? idregistroitem { get; set; }

    public int? IDPRODUCTOORIGINAL { get; set; }

    public bool? bloqueoenfactura { get; set; }
}
