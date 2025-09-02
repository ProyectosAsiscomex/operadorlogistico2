using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_RC_DETALLE
{
    public int idcausacion { get; set; }

    public DateOnly? FECHA { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NRODOCUMENTO { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? PLANO { get; set; }
}
