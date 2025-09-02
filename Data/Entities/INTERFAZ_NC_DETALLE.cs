using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_NC_DETALLE
{
    [StringLength(50)]
    [Unicode(false)]
    public string? NRONOTA { get; set; }

    public DateOnly? FECHA { get; set; }

    public string? PLANO { get; set; }
}
