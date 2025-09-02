using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_RC_ENCABEZADO
{
    [StringLength(200)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    public DateOnly? FECHA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    public string? PLANO { get; set; }
}
