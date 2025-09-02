using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_TE2_DETALLE
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? fechayhora { get; set; }

    public DateOnly? FECHA { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NRODOCUMENTO { get; set; }

    public string? PLANO { get; set; }
}
