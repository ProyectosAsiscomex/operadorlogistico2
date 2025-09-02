using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class IndicadorCicloFacturacion
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDO { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(1000)]
    public string? Indicador { get; set; }

    public int? Año { get; set; }

    public int? NMes { get; set; }

    [StringLength(30)]
    public string? Mes { get; set; }

    [StringLength(42)]
    [Unicode(false)]
    public string Evento { get; set; } = null!;

    [Column("Fecha Evento", TypeName = "datetime")]
    public DateTime? Fecha_Evento { get; set; }

    [Column("Fecha Factura", TypeName = "smalldatetime")]
    public DateTime? Fecha_Factura { get; set; }

    public int? Ciclo { get; set; }
}
