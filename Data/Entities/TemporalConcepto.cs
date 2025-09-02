using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class TemporalConcepto
{
    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
