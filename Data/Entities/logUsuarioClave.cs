using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("logUsuarioClave")]
public partial class logUsuarioClave
{
    [Key]
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaModificacion { get; set; }

    [StringLength(250)]
    public string? Accion { get; set; }
}
