using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ContenedoresDevolucion")]
public partial class ContenedoresDevolucion
{
    [Key]
    public int idDevolucion { get; set; }

    [StringLength(50)]
    public string? Numero { get; set; }

    [StringLength(500)]
    public string? OperadorLogistico { get; set; }

    [StringLength(300)]
    public string? CiudadEntrega { get; set; }

    [StringLength(500)]
    public string? Estado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainicialdevolucion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafinaldevolucion { get; set; }

    public string? estadofisico { get; set; }
}
