using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_CAUSACIONE
{
    [StringLength(50)]
    [Unicode(false)]
    public string? nrocontabilidad { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NROFACTURA { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FECHAFACTRUA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NRODO { get; set; }

    [StringLength(458)]
    public string PLANO { get; set; } = null!;
}
