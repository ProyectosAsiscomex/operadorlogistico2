using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("PrefiltrosReporte")]
public partial class PrefiltrosReporte
{
    [Key]
    public int idPrefiltrosReporte { get; set; }

    public int? IdTablaOrigen { get; set; }

    public int? IdCampoOrigen { get; set; }

    [StringLength(50)]
    public string? Condicion { get; set; }

    public string? Valor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Enlace { get; set; }

    public int? IdReporteUsuario { get; set; }

    [StringLength(500)]
    public string? NombreReporte { get; set; }
}
