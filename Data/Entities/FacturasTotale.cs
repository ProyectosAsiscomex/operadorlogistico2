using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class FacturasTotale
{
    [Column("Nro Factura")]
    [StringLength(50)]
    public string? Nro_Factura { get; set; }

    public DateOnly? Fecha { get; set; }

    [Column("Fecha Vence")]
    public DateOnly? Fecha_Vence { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Sede { get; set; }

    [Column("Tipo Operación")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Tipo_Operación { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(802)]
    public string? Comercial { get; set; }

    [StringLength(50)]
    public string? DO { get; set; }

    [Column("Valor Factura Con IVA menos Retencion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Valor_Factura_Con_IVA_menos_Retencion { get; set; }

    [Column("Valor Factura Sin Impuestos")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Valor_Factura_Sin_Impuestos { get; set; }

    public long? Anticipos { get; set; }

    [Column("Total Causaciones")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Total_Causaciones { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Pedido { get; set; }

    [Column("Tasa Cambio", TypeName = "money")]
    public decimal? Tasa_Cambio { get; set; }

    [StringLength(20)]
    public string? Usuario { get; set; }

    [Column("Fecha Creacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Creacion { get; set; }

    [Column("Ult. Modificacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Ult__Modificacion { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Anulada { get; set; } = null!;

    [Column("Usuario Anula")]
    [StringLength(20)]
    public string? Usuario_Anula { get; set; }

    [Column("Fecha de Anulacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_de_Anulacion { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Sincronizada { get; set; } = null!;
}
