using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class SeguimientoItemEvento
{
    [Key]
    public int idSeguimientoItemEvento { get; set; }

    public int? idSeguimientoItem { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }

    [StringLength(20)]
    public string? tipousuario { get; set; }

    public int? idusuario { get; set; }

    public bool? paralizado { get; set; }

    public bool? desparalizado { get; set; }

    public string? comentario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainicial { get; set; }

    public bool? publico { get; set; }

    public bool? cliente { get; set; }
}
