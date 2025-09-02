using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_LEGALIZA_ENCABEZADO
{
    [StringLength(50)]
    [Unicode(false)]
    public string? numerocontable { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string NroDocumento { get; set; } = null!;

    public DateOnly? FECHA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    public string? PLANO { get; set; }
}
