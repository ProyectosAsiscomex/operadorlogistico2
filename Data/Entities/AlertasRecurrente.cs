using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AlertasRecurrente
{
    [Key]
    public int IdAlertaRecurrente { get; set; }

    public int? IdAlerta { get; set; }

    public int? Programacion { get; set; }

    [StringLength(20)]
    public string? Prog { get; set; }
}
