using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TipoNegociacion")]
public partial class TipoNegociacion
{
    public int idtiponegociacion { get; set; }

    public int? codigo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
