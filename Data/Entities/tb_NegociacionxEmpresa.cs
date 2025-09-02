using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_NegociacionxEmpresa")]
public partial class tb_NegociacionxEmpresa
{
    [Key]
    public int idNegociacion { get; set; }

    public int? idEmpresa { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaComentario { get; set; }

    public int? idUsuario { get; set; }

    public string? Comentario { get; set; }
}
