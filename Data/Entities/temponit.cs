using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class temponit
{
    [StringLength(500)]
    public string? razonsocial { get; set; }

    [StringLength(100)]
    public string? nit { get; set; }

    [StringLength(500)]
    public string? CT { get; set; }
}
