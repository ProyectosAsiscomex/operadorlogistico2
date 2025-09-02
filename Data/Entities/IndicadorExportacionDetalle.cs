using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("IndicadorExportacionDetalle")]
public partial class IndicadorExportacionDetalle
{
    [Key]
    public int Idindicadordetalle { get; set; }

    public int? idIndicador { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NombreMedicion { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EstadoPrimario { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EstadoSecundario { get; set; }

    public byte? dias { get; set; }

    public byte? orden { get; set; }
}
