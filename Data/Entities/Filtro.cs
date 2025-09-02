using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Filtro
{
    [Key]
    public int idconsulta { get; set; }

    public string? idFiltro { get; set; }

    [StringLength(1)]
    public string? concatenar { get; set; }

    [StringLength(200)]
    public string? campo { get; set; }

    public bool? negar { get; set; }

    [StringLength(200)]
    public string? operador { get; set; }

    [StringLength(500)]
    public string? valor { get; set; }

    [StringLength(200)]
    public string? nombrefiltro { get; set; }

    [StringLength(200)]
    public string? formulario { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }

    public bool? publica { get; set; }
}
