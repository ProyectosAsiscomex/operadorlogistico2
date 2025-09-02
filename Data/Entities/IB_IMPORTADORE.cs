using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("IB_IMPORTADORES")]
public partial class IB_IMPORTADORE
{
    public double? ID_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? NUMERO_IDENTIFICACION { get; set; }
}
