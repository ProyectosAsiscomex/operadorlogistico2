using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AlertaComentario
{
    [Key]
    public int IdComentarios { get; set; }

    public int? IdAlerta { get; set; }

    [StringLength(200)]
    public string? Usuario { get; set; }

    [StringLength(500)]
    public string? Comentario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fecha { get; set; }
}
