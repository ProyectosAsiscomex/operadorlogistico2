using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Traslado
{
    [Key]
    public int idtraslado { get; set; }

    public int? tipo { get; set; }

    public int? idempresa { get; set; }

    public bool? generico { get; set; }

    [StringLength(100)]
    public string? nombre { get; set; }

    [StringLength(300)]
    public string? descripcion { get; set; }

    [StringLength(300)]
    public string? formulario { get; set; }

    [StringLength(300)]
    public string? manual { get; set; }
}
