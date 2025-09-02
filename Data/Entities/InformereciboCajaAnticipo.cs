using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class InformereciboCajaAnticipo
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column("Numero Recibo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Numero_Recibo { get; set; }

    [Column("Forma Pago")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Forma_Pago { get; set; }

    [Column("Documento Numero")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Documento_Numero { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Observacion { get; set; }

    [Column("Valor Total Recibo", TypeName = "money")]
    public decimal? Valor_Total_Recibo { get; set; }

    public bool? Anulado { get; set; }

    [Column("Motivo Anulacion")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? Motivo_Anulacion { get; set; }

    [Column("Numero DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Numero_DO { get; set; }

    [Column("Valor Pagado", TypeName = "money")]
    public decimal? Valor_Pagado { get; set; }
}
