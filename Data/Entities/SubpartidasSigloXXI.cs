using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("SubpartidasSigloXXI")]
public partial class SubpartidasSigloXXI
{
    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    public double? iva { get; set; }

    public double? Gravamen { get; set; }

    [StringLength(255)]
    public string? reg { get; set; }
}
