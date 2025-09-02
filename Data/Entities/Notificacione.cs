using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Notificacione
{
    [Key]
    public int idNotificacion { get; set; }

    public string? Notificacion { get; set; }

    public string? MensajeTecnico { get; set; }

    public string? Fecha { get; set; }

    public bool? usuario { get; set; }

    public short? prioridad { get; set; }
}
