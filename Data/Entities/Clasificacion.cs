using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Clasificacion")]
public partial class Clasificacion
{
    [Key]
    public int idclasificacion { get; set; }

    public int? idminima { get; set; }

    [StringLength(200)]
    public string? nivel { get; set; }

    [StringLength(10)]
    public string? desde { get; set; }

    [StringLength(10)]
    public string? hasta { get; set; }

    [StringLength(10)]
    public string? orden { get; set; }

    public bool? registro { get; set; }

    public bool? dim { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public bool? habilitado { get; set; }

    public int? idusuario { get; set; }

    public bool? dex { get; set; }

    public bool? hastavacio { get; set; }

    public int? iddescripcion { get; set; }
}
