using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("liquidacion_leonisa")]
public partial class liquidacion_leonisa
{
    [Key]
    public int idliquidacionleonisa { get; set; }

    [StringLength(100)]
    public string? importador { get; set; }

    [StringLength(100)]
    public string? fecha_rad { get; set; }

    [Column("do")]
    [StringLength(100)]
    public string? _do { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nro_pedido { get; set; }

    public bool? cerrado { get; set; }
}
