using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Frecuencium
{
    public int idfrecuencia { get; set; }

    [StringLength(200)]
    public string? frecuencia { get; set; }
}
