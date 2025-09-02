using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class ArqueoCaja
{
    [StringLength(50)]
    [Unicode(false)]
    public string? consecutivo { get; set; }

    [StringLength(100)]
    public string? pagadoa { get; set; }

    [StringLength(200)]
    public string? Gasto { get; set; }

    [Column(TypeName = "money")]
    public decimal? Valorpagado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    public int? idciudad { get; set; }

    public bool? anulado { get; set; }
}
