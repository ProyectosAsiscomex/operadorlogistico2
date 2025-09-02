using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("liquidacion_leonisadetalle")]
public partial class liquidacion_leonisadetalle
{
    [Key]
    public int idliquidaciondetalle { get; set; }

    [StringLength(100)]
    public string? importador { get; set; }

    [StringLength(100)]
    public string? fecha_rad { get; set; }

    [StringLength(100)]
    public string? inomb { get; set; }

    [StringLength(100)]
    public string? cuenta { get; set; }

    [StringLength(100)]
    public string? naturaleza { get; set; }

    [StringLength(100)]
    public string? ccodi { get; set; }

    [Column("do")]
    [StringLength(30)]
    public string? _do { get; set; }

    [StringLength(20)]
    public string? nit { get; set; }

    [StringLength(50)]
    public string? factura { get; set; }

    [StringLength(10)]
    public string? item { get; set; }

    [StringLength(100)]
    public string? valor { get; set; }

    [StringLength(100)]
    public string? valor_iva { get; set; }

    [StringLength(100)]
    public string? valor_reteiva { get; set; }

    [StringLength(100)]
    public string? Porret { get; set; }

    [StringLength(100)]
    public string? valor_ret { get; set; }

    [StringLength(100)]
    public string? por_ica { get; set; }

    [StringLength(100)]
    public string? valor_ica { get; set; }

    [StringLength(100)]
    public string? por_cree { get; set; }

    [StringLength(100)]
    public string? valor_cree { get; set; }
}
