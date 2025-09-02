using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class tiempovaciado
{
    [StringLength(200)]
    public string? embarcador { get; set; }

    public int? tiempo { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? empresa { get; set; }

    public int? meslevante { get; set; }
}
