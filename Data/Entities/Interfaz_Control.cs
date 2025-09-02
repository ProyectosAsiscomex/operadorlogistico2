using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Interfaz_Control")]
public partial class Interfaz_Control
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

    public int? idComentario { get; set; }

    public int? idusuario { get; set; }

    [Unicode(false)]
    public string? Sentencia { get; set; }

    [Key]
    public int idinterfaz { get; set; }

    [Unicode(false)]
    public string? Sentenciaupdate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IDPROVEEDOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cnit { get; set; }
}
