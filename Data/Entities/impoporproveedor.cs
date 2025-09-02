using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class impoporproveedor
{
    public string? proveedor { get; set; }

    [StringLength(50)]
    public string? paisorigen { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobusd { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Emprea { get; set; }
}
