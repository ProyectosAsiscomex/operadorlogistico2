using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Correo
{
    [StringLength(50)]
    public string? NIT { get; set; }

    [StringLength(1000)]
    public string? empresa { get; set; }

    public string? correos { get; set; }
}
