using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class IndicadorCicloFacturacionAgrupado
{
    public int? NMes { get; set; }

    [StringLength(30)]
    public string? Mes { get; set; }

    [Column("Total Operaciones")]
    public int? Total_Operaciones { get; set; }

    [Column("Ciclo total")]
    public int? Ciclo_total { get; set; }

    public int? Promedio { get; set; }

    [StringLength(1000)]
    public string? Indicador { get; set; }

    public int? Año { get; set; }
}
