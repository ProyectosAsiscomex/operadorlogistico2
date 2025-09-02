using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class NotificacionesLeidasUsuario
{
    [Key]
    public int idnotificacionleida { get; set; }

    public int? idnotificacion { get; set; }

    public int? idusuario { get; set; }
}
