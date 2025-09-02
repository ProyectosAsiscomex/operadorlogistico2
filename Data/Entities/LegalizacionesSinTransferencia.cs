using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class LegalizacionesSinTransferencia
{
    [Column("Razon Social")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Razon_Social { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    [Column("Valor Neto", TypeName = "decimal(30, 2)")]
    public decimal? Valor_Neto { get; set; }
}
