using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class CalificacionProveedore
{
    [Key]
    public int idCalificacion { get; set; }

    [Unicode(false)]
    public string? xmlCalificacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idDo { get; set; }

    public int? usuarioid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? proveedorId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCierre { get; set; }
}
