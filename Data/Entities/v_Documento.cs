using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class v_Documento
{
    public short id { get; set; }

    [StringLength(500)]
    public string nombre { get; set; } = null!;

    [StringLength(50)]
    public string campoFiltro { get; set; } = null!;

    public byte numeroPaginas { get; set; }
}
