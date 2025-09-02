using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ReportesUsuario")]
public partial class ReportesUsuario
{
    [Key]
    public int IdReporteUsuario { get; set; }

    [StringLength(500)]
    public string? NombreReporte { get; set; }

    public int? IdTablaOrigen { get; set; }

    public int? IdCampoOrigen { get; set; }

    [StringLength(500)]
    public string? NombreTablaOrigen { get; set; }

    [StringLength(500)]
    public string? NombreCampoOrigen { get; set; }
}
