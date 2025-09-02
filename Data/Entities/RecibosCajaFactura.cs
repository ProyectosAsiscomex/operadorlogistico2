using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class RecibosCajaFactura
{
    public int idfactura { get; set; }

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

    public int Anulado { get; set; }

    [Column("Motivo Anulacion")]
    [StringLength(2000)]
    [Unicode(false)]
    public string Motivo_Anulacion { get; set; } = null!;

    [Column("Numero Factura")]
    [StringLength(50)]
    public string? Numero_Factura { get; set; }

    [Column("Fecha Factura", TypeName = "smalldatetime")]
    public DateTime? Fecha_Factura { get; set; }

    [Column("Valor total Factura", TypeName = "money")]
    public decimal? Valor_total_Factura { get; set; }

    [Column("Motivo Retiro")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Motivo_Retiro { get; set; }

    [Column(TypeName = "money")]
    public decimal? recibido { get; set; }

    [Column("Documento Devolucion")]
    public string? Documento_Devolucion { get; set; }

    [Column("Fecha Devolucion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Devolucion { get; set; }
}
