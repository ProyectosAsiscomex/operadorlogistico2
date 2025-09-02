using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class TiposDeDocumento
{
    public int idtipodedocumento { get; set; }

    [StringLength(200)]
    public string? Descripcion { get; set; }

    public int? codigo { get; set; }
}
