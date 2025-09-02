using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class negociacione
{
    public long? nit { get; set; }

    [Unicode(false)]
    public string? negociacion { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? formapago { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? hora { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? usuario { get; set; }
}
