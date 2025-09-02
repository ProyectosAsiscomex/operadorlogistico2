using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class v_Variable
{
    public int id { get; set; }

    [StringLength(50)]
    public string Impresora { get; set; } = null!;

    [StringLength(500)]
    public string Documento { get; set; } = null!;
}
