using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Modalidad")]
public partial class Modalidad
{
    [Key]
    public int idmodalidad { get; set; }

    public string? descripcion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    public int? idObservacion { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ControlTemporal { get; set; }

    public bool? TemporalPerfecActivo { get; set; }

    public bool? TemporalCortoPlazo { get; set; }

    public bool? TemporalLargoPlazo { get; set; }

    public bool? ActivarNumeroCuotas { get; set; }

    public bool? ActivarPeriocidad { get; set; }

    public bool? CalcularAutValorCuotas { get; set; }

    public bool? ActivarLiquidacionUSD { get; set; }

    public bool? ObligarResultadoValorFOB { get; set; }

    public bool? ObligarResultadoSubtotal { get; set; }

    public bool? ObligarResultadoGenerado { get; set; }

    public bool? ObligarResultadoPagado { get; set; }

    public bool? ExcluirControlTempo { get; set; }
}
