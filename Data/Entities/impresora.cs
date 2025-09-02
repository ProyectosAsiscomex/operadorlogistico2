using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("impresora")]
public partial class impresora
{
    /// <summary>
    /// Número unico que identifica la impresora
    /// </summary>
    public byte id { get; set; }

    /// <summary>
    /// Nombre de la impresora
    /// </summary>
    [StringLength(50)]
    public string nombre { get; set; } = null!;
}
