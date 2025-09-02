using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AlertasAdjunto
{
    [Key]
    public int IdAdjunto { get; set; }

    public int? IdAlerta { get; set; }

    [StringLength(200)]
    public string? Titulo { get; set; }

    [StringLength(200)]
    public string? NombreArchivo { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fecha { get; set; }
}
