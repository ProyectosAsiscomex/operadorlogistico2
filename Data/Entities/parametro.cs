using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class parametro
{
    [StringLength(50)]
    public string letraTipo { get; set; } = null!;

    public byte letraTamano { get; set; }

    public short MargenIzquierdo { get; set; }

    public short MargenSuperior { get; set; }
}
