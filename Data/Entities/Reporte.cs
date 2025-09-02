using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Reporte
{
    /// <summary>
    /// Numero unico que identifica el registro dentro de la tabla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre del reporte
    /// </summary>
    [StringLength(100)]
    public string NombreReporte { get; set; } = null!;

    /// <summary>
    /// Nombre de la tabla o vista que compone el reporte
    /// </summary>
    [StringLength(100)]
    public string Tabla_Vista { get; set; } = null!;
}
