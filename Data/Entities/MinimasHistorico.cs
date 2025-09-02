using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("MinimasHistorico")]
public partial class MinimasHistorico
{
    [StringLength(5)]
    public string? cia { get; set; }

    [StringLength(300)]
    public string? codigo { get; set; }

    public string? nombre { get; set; }

    public string? minima { get; set; }
}
