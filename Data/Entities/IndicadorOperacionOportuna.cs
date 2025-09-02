using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class IndicadorOperacionOportuna
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDO { get; set; }

    [StringLength(1000)]
    public string? Indicador { get; set; }

    public int? Año { get; set; }

    public int? NMes { get; set; }

    [StringLength(30)]
    public string? Mes { get; set; }

    [Column("Evento estimado")]
    [StringLength(53)]
    [Unicode(false)]
    public string Evento_estimado { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Estimada { get; set; }

    [Column("Evento real")]
    [StringLength(34)]
    [Unicode(false)]
    public string Evento_real { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Real { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Estado { get; set; } = null!;
}
