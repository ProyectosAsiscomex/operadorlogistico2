using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class GeneracionPagosCliente
{
    [Key]
    public int idGeneracionPagoC { get; set; }

    public int? idCliente { get; set; }

    public int? idFormaPago { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechayHora { get; set; }

    public int? idBanco { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorTotalPagar { get; set; }

    [Unicode(false)]
    public string? Concepto { get; set; }

    public bool? plano { get; set; }

    public bool? anulado { get; set; }
}
