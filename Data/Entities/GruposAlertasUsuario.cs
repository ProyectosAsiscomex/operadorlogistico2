using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class GruposAlertasUsuario
{
    [Key]
    public int IdGrupoAlertas { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdGrupo { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    public string? Nombre { get; set; }
}
