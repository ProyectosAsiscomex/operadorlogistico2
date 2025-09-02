using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Configuracion")]
public partial class Configuracion
{
    [Key]
    public int idConfiguracion { get; set; }

    public bool? saedo { get; set; }

    public bool? docsfaltantes { get; set; }

    [StringLength(500)]
    public string? correodocsfaltantes { get; set; }

    [StringLength(500)]
    public string? rutadocsadjuntos { get; set; }

    public bool? ejecutarlineaasiscomex { get; set; }
}
