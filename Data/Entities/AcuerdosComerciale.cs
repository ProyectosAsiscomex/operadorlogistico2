using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AcuerdosComerciale
{
    [Key]
    public int IdAcuerdo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    public bool? Estado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaHora { get; set; }

    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? bd { get; set; }
}
