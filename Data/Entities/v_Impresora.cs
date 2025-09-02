using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class v_Impresora
{
    public byte id { get; set; }

    [StringLength(50)]
    public string nombre { get; set; } = null!;
}
