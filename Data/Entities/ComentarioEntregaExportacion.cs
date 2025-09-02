using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ComentarioEntregaExportacion")]
public partial class ComentarioEntregaExportacion
{
    [Key]
    public int idComentario { get; set; }

    public int? idFactExpo { get; set; }

    public int? idEntrega { get; set; }

    public string? cComentario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaComentario { get; set; }

    public int? nQuien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? despacho { get; set; }
}
