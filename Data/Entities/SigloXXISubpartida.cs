using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class SigloXXISubpartida
{
    public double? Identificador { get; set; }

    public double? codigo { get; set; }

    public double? iva { get; set; }

    public double? Gravamen { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? subpartida { get; set; }
}
