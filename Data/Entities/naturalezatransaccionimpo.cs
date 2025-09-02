using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("naturalezatransaccionimpo")]
public partial class naturalezatransaccionimpo
{
    public int idnaturalezatransaccionimpo { get; set; }

    public int? codigonaturalezatransaccionimpo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? descripcionnaturalezatransaccionimpo { get; set; }
}
