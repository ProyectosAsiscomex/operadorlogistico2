using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class ConfiguracionPerfile
{
    [Key]
    public int idPerfilConfiguracino { get; set; }

    public int? idPerfil { get; set; }

    public int? idFormulario { get; set; }

    public bool? guardar { get; set; }

    public bool? eliminar { get; set; }

    public bool? consultar { get; set; }

    public bool? modificar { get; set; }
}
