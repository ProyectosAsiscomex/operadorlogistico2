using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALSEGUROS")]
public partial class TEMPORALSEGURO
{
    [StringLength(255)]
    public string? NUMERO_IDENTIFICACION { get; set; }

    public double? PORCENTAJE_SEGURO { get; set; }

    public int? idexportador { get; set; }
}
