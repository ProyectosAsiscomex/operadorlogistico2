using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class EstadosMercancium
{
    [Key]
    public int idestado { get; set; }

    [StringLength(100)]
    public string? nombre { get; set; }

    public int? diasduracion { get; set; }

    public int? diasalerta { get; set; }

    [StringLength(500)]
    public string? observaciones { get; set; }

    [StringLength(100)]
    public string? tipo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? equivalenciaTDM { get; set; }
}
