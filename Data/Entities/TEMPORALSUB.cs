using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALSUB")]
public partial class TEMPORALSUB
{
    [StringLength(255)]
    public string? Subpartida { get; set; }

    [Column(" arancel")]
    public double? _arancel { get; set; }

    [Column(" IVA")]
    public double? _IVA { get; set; }
}
