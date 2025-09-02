using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_CAUSACIONES_ENCABEZADO
{
    [StringLength(50)]
    [Unicode(false)]
    public string? nrocontabilidad { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NROFACTURA { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactrua { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NRODO { get; set; }

    public string? PLANO { get; set; }
}
