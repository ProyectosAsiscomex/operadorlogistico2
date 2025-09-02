using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TemporalClasificacion")]
public partial class TemporalClasificacion
{
    [StringLength(50)]
    [Unicode(false)]
    public string? capitulo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nivel { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? desde { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? hasta { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? orden { get; set; }

    [Unicode(false)]
    public string? ejemplo { get; set; }
}
