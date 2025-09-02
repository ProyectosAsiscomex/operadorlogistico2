using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_ND_ENCABEZADO
{
    [StringLength(20)]
    [Unicode(false)]
    public string? NRONOTACREDITO { get; set; }

    public DateOnly? FECHA { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NRODONOTA { get; set; }

    public string? PLANO { get; set; }
}
