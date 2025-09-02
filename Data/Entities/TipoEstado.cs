using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TipoEstado")]
public partial class TipoEstado
{
    public int Id { get; set; }

    [StringLength(250)]
    public string? Descripcion { get; set; }

    public string? Contenido { get; set; }
}
