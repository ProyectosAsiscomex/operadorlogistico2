using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("UsuariosControl")]
public partial class UsuariosControl
{
    [StringLength(255)]
    public string? ciudad { get; set; }

    public double? cedula { get; set; }

    [StringLength(255)]
    public string? nombre { get; set; }

    public int? idsede { get; set; }
}
