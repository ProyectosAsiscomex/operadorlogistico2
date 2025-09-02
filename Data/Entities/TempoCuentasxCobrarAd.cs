using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TempoCuentasxCobrarAd")]
public partial class TempoCuentasxCobrarAd
{
    [StringLength(255)]
    public string? ffech { get; set; }

    [StringLength(255)]
    public string? prefijo { get; set; }

    public double? ffact { get; set; }

    [StringLength(255)]
    public string? fnume { get; set; }
}
