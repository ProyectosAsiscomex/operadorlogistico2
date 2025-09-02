using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class notacredito
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [Column("Nro Nota")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Nota { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column("Valor Terceros", TypeName = "money")]
    public decimal? Valor_Terceros { get; set; }

    [Column("Valor propios", TypeName = "money")]
    public decimal? Valor_propios { get; set; }

    [Column("Valor bruto", TypeName = "money")]
    public decimal? Valor_bruto { get; set; }

    [Unicode(false)]
    public string? Concepto { get; set; }
}
