using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LugarDestinoFinal")]
public partial class LugarDestinoFinal
{
    [Key]
    public int idlugardestinofinal { get; set; }

    public int? codigo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadesde { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechahasta { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? administracion { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? direccion { get; set; }

    public int? tipodeposito { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
