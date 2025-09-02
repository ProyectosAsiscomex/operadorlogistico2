using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class ControlCorreo
{
    [Key]
    public int IdCorreo { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Motivo { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime Fecha { get; set; }
}
