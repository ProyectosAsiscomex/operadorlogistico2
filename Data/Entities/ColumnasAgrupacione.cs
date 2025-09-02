using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class ColumnasAgrupacione
{
    [Key]
    public int idcolumna { get; set; }

    [StringLength(200)]
    public string? HeaderColumna { get; set; }

    [StringLength(200)]
    public string? NombreCampo { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }

    [StringLength(200)]
    public string? formulario { get; set; }

    [StringLength(200)]
    public string? nombrefiltro { get; set; }
}
