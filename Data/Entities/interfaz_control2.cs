using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("interfaz_control2")]
public partial class interfaz_control2
{
    [StringLength(30)]
    [Unicode(false)]
    public string? Do { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? tipo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha_solicitud { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha_ejecucion { get; set; }

    [Unicode(false)]
    public string? estado { get; set; }

    public int? idcomentario { get; set; }

    public int? idusuario { get; set; }

    [Unicode(false)]
    public string? sentencia { get; set; }

    [Key]
    public int idinterfaz { get; set; }

    [Unicode(false)]
    public string? sentenciaupdate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idproveedor { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cnit { get; set; }

    public int? idinterfaz2 { get; set; }
}
