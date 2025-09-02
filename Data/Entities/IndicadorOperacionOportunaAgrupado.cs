using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class IndicadorOperacionOportunaAgrupado
{
    public int? Orden { get; set; }

    public int? Año { get; set; }

    [StringLength(30)]
    public string? Mes { get; set; }

    [StringLength(1000)]
    public string? Indicador { get; set; }

    public int? Cumplida { get; set; }

    public int? Incumplidos { get; set; }

    [Column("%")]
    public int? _ { get; set; }
}
