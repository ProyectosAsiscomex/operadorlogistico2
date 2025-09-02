using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SituacionDO")]
public partial class SituacionDO
{
    [Key]
    public int idComentario { get; set; }

    public int? idusuario { get; set; }

    public int? iddo { get; set; }

    public bool? publico { get; set; }

    [Unicode(false)]
    public string? comentario { get; set; }

    public bool? EnviadoControl { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fecha { get; set; }
}
