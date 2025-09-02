using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("logRobotSiglo")]
public partial class logRobotSiglo
{
    [Key]
    public int idlogRobotSiglo { get; set; }

    public int? idDecla { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Proceso { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    public bool? Estado { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Archivo { get; set; }
}
