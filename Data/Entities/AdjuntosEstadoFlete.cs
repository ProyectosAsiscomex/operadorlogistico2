using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AdjuntosEstadoFlete
{
    [Key]
    public int Id { get; set; }

    public int? iddo { get; set; }

    public int? idcotizacion { get; set; }

    public string? nombre { get; set; }

    public string? ruta { get; set; }
}
