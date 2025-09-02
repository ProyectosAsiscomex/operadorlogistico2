using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class EventosAlerta
{
    [Key]
    public int idEvento { get; set; }

    [StringLength(200)]
    public string? NombreEvento { get; set; }

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [StringLength(100)]
    public string? SP { get; set; }

    public int? Identificador { get; set; }
}
