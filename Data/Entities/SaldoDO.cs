using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class SaldoDO
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroDO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacreacion { get; set; }

    [Column("Anticipos Solicitados", TypeName = "money")]
    public decimal Anticipos_Solicitados { get; set; }

    [Column("Anticipos Pagados", TypeName = "money")]
    public decimal Anticipos_Pagados { get; set; }

    [Column("Pago de Facturas Recibidos", TypeName = "money")]
    public decimal Pago_de_Facturas_Recibidos { get; set; }

    [Column("Valores Causados", TypeName = "decimal(38, 2)")]
    public decimal Valores_Causados { get; set; }

    [Column("Pagado a Terceros", TypeName = "money")]
    public decimal Pagado_a_Terceros { get; set; }

    [Column("Saldo (Anticipos Pagados + Facturas Pagadas - Pagado a Terceros)", TypeName = "money")]
    public decimal Saldo__Anticipos_Pagados___Facturas_Pagadas___Pagado_a_Terceros_ { get; set; }

    [Column("Saldo (Anticipos Pagados + Facturas Pagadas - Valores Causados)", TypeName = "decimal(38, 2)")]
    public decimal Saldo__Anticipos_Pagados___Facturas_Pagadas___Valores_Causados_ { get; set; }
}
