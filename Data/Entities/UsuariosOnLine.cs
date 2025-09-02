using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("UsuariosOnLine")]
public partial class UsuariosOnLine
{
    [Key]
    public int idUsuarioOnLine { get; set; }

    public int? idusuario { get; set; }

    [StringLength(500)]
    public string? Nombre { get; set; }

    public int? idexportador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ingreso { get; set; }

    [StringLength(100)]
    public string? idsession { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? salida { get; set; }
}
