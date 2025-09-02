using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_LEGALIZA_DETALLE
{
    [StringLength(50)]
    [Unicode(false)]
    public string? numerocontable { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string NRODOCUMENTO { get; set; } = null!;

    public DateOnly? fecha { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? PLANO { get; set; }
}
