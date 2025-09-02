using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Minima
{
    [Key]
    public int iddescripcion { get; set; }

    [StringLength(3000)]
    public string? descripcion { get; set; }

    public int? orden { get; set; }

    public int? codigo { get; set; }

    [StringLength(100)]
    public string? tipodato { get; set; }

    public int? longitud { get; set; }

    [StringLength(50)]
    public string? obligatorio { get; set; }

    [StringLength(50)]
    public string? detalle { get; set; }

    [StringLength(100)]
    public string? tipo { get; set; }

    public string? ejemplo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BuscarAndina { get; set; }
}
