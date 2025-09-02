using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AdjuntosEstado")]
public partial class AdjuntosEstado
{
    [Key]
    public int Id { get; set; }

    public int? IdDo { get; set; }

    public int? IdEstado { get; set; }

    public string? Nombre { get; set; }

    public string? Ruta { get; set; }
}
