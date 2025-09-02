using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class correostercero
{
    [StringLength(50)]
    [Unicode(false)]
    public string? nit { get; set; }

    [Unicode(false)]
    public string? correos { get; set; }

    public int? idarea { get; set; }

    public int? idempresa { get; set; }
}
