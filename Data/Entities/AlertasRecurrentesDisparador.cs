using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AlertasRecurrentesDisparador")]
public partial class AlertasRecurrentesDisparador
{
    [Key]
    public int IdDisparar { get; set; }

    public int? IdAlertaRecurrente { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaRealizacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDisparar { get; set; }

    [StringLength(100)]
    public string? Usuario { get; set; }

    public int? IdUsuario { get; set; }
}
