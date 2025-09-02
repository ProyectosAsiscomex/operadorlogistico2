using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("FACTURASCONTROL07$")]
public partial class FACTURASCONTROL07_
{
    [StringLength(255)]
    public string? fnume { get; set; }

    [StringLength(255)]
    public string? prefijo { get; set; }

    public double? ffact { get; set; }

    [StringLength(255)]
    public string? ffech { get; set; }

    [StringLength(255)]
    public string? fvence { get; set; }

    public double? fcodi { get; set; }

    public double? tercero { get; set; }

    [StringLength(255)]
    public string? kconc { get; set; }

    [StringLength(255)]
    public string? anomb { get; set; }

    public double? tasa_cam { get; set; }

    public double? fterceros { get; set; }

    public double? fpropios { get; set; }

    public double? fiva { get; set; }

    public double? fanticipo { get; set; }

    public double? frete_iva { get; set; }

    public double? valorreal { get; set; }

    public double? fpago { get; set; }

    [StringLength(255)]
    public string? mfact { get; set; }

    [StringLength(255)]
    public string? mtipo { get; set; }

    public double? mvalo { get; set; }
}
