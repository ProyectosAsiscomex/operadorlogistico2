using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("PROSALON")]
public partial class PROSALON
{
    [StringLength(255)]
    public string? REFERENCIA { get; set; }

    [StringLength(255)]
    public string? DESCRIPCION { get; set; }

    public int? iddeclaracion { get; set; }

    public string? levantes { get; set; }
}
