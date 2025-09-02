using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class subproceso
{
    [Key]
    public int idsubproceso { get; set; }

    public int? Orden { get; set; }

    [Unicode(false)]
    public string? Descripcón { get; set; }

    public int? IdModotransporte { get; set; }

    public bool? obligatorio { get; set; }
}
