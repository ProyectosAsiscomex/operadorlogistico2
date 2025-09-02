using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("actividadeconomica")]
public partial class actividadeconomica
{
    [Key]
    public int idactividadeconomica { get; set; }

    public int? codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? descripcion { get; set; }
}
