using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ConfiguracionListaChequeo")]
public partial class ConfiguracionListaChequeo
{
    [Key]
    public int idConfiguracionList { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Modalidad { get; set; }

    public int? idTipoDocumento { get; set; }

    public int? idActividad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreTabla { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CamposTabla { get; set; }
}
