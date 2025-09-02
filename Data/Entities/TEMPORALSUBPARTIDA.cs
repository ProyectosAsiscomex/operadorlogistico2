using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALSUBPARTIDAS")]
public partial class TEMPORALSUBPARTIDA
{
    [StringLength(50)]
    [Unicode(false)]
    public string? SUBPARTIDA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UNIDAD { get; set; }

    [Unicode(false)]
    public string? DESCRIPCION { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? ARANCEL { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? IVA { get; set; }

    [Unicode(false)]
    public string? APLICAANTICIPADA { get; set; }

    [Unicode(false)]
    public string? LLAMADOS { get; set; }

    public int? IDUNIDADDIAN { get; set; }
}
