using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("CarteraOtroSoftware")]
public partial class CarteraOtroSoftware
{
    [StringLength(2)]
    [Unicode(false)]
    public string? TIPO { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? PREFIJO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NUMERO { get; set; }

    [Column(TypeName = "money")]
    public decimal? PROPIOS { get; set; }

    [Column(TypeName = "money")]
    public decimal? TERCEROS { get; set; }

    [Column(TypeName = "money")]
    public decimal? IVA { get; set; }

    [Column(TypeName = "money")]
    public decimal? RETENCION { get; set; }

    [Column(TypeName = "money")]
    public decimal? TOTAL { get; set; }
}
