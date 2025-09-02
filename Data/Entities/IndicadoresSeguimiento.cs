using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("IndicadoresSeguimiento")]
public partial class IndicadoresSeguimiento
{
    [Key]
    public int idindicadorseguimiento { get; set; }

    public int? idDo { get; set; }

    [StringLength(400)]
    public string? estado1 { get; set; }

    [StringLength(400)]
    public string? estado2 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha1 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha2 { get; set; }

    public int? indicador { get; set; }

    public int? idestado1 { get; set; }

    public int? idestado2 { get; set; }

    public int? orden { get; set; }

    public int? idindicador { get; set; }

    public int? idexportador { get; set; }

    public string? comentario { get; set; }

    [StringLength(300)]
    public string? Medicion { get; set; }
}
