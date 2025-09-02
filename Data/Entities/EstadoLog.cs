using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EstadoLog")]
public partial class EstadoLog
{
    [Key]
    public int Id { get; set; }

    public int? IdTipoEstado { get; set; }

    public string Destinatario { get; set; } = null!;

    public string? Informacion { get; set; }

    [StringLength(200)]
    public string? Usuario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaHora { get; set; }

    public int? IdDO { get; set; }
}
