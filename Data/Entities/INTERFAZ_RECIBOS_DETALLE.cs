using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_RECIBOS_DETALLE
{
    [StringLength(50)]
    [Unicode(false)]
    public string? ReciboNumero { get; set; }

    public DateOnly? fecha { get; set; }

    [StringLength(4000)]
    public string? PLANO { get; set; }
}
