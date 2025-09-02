using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("MinimasCatalogoP")]
public partial class MinimasCatalogoP
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

    [StringLength(4000)]
    public string? v_alfa { get; set; }

    public int? v_num_otro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? v_otro { get; set; }

    public int? item { get; set; }

    public int? IDMINIMA1 { get; set; }

    public int? IDMINIMA2 { get; set; }

    public int? IDMINIMA { get; set; }
}
