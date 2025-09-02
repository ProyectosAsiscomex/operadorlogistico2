using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ErroresImpo")]
public partial class ErroresImpo
{
    [Key]
    public int iderroresimpo { get; set; }

    [StringLength(100)]
    public string? Formulario { get; set; }

    [StringLength(100)]
    public string? Proceso { get; set; }

    [StringLength(500)]
    public string? Mensaje { get; set; }

    [StringLength(100)]
    public string? fecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? estado { get; set; }
}
