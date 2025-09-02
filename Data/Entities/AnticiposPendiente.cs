using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class AnticiposPendiente
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Empresa { get; set; }

    [StringLength(100)]
    public string? Proveedor { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column("D.O.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? D_O_ { get; set; }

    [Column("Valor Solicitado", TypeName = "decimal(38, 2)")]
    public decimal? Valor_Solicitado { get; set; }

    [Column("Valor Pagado", TypeName = "money")]
    public decimal? Valor_Pagado { get; set; }

    [Column("Nro Legalizado")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nro_Legalizado { get; set; }

    [Column("Valor Neto Legalización", TypeName = "decimal(38, 2)")]
    public decimal? Valor_Neto_Legalización { get; set; }

    [Column("Saldo a favor", TypeName = "decimal(38, 2)")]
    public decimal? Saldo_a_favor { get; set; }
}
