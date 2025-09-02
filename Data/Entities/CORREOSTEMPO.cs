using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("CORREOSTEMPO")]
public partial class CORREOSTEMPO
{
    [StringLength(50)]
    public string? ccodi { get; set; }

    [StringLength(255)]
    public string? cnomb { get; set; }

    [StringLength(255)]
    public string? lista { get; set; }
}
