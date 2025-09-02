using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_SF_ENCABEZADO
{
    [StringLength(50)]
    [Unicode(false)]
    public string? NRODOCUMENTO { get; set; }

    public DateOnly? FECHA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string nrodo { get; set; } = null!;

    [Unicode(false)]
    public string? PLANO { get; set; }
}
