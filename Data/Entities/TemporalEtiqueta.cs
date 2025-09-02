using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class TemporalEtiqueta
{
    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [Unicode(false)]
    public string? minima { get; set; }
}
