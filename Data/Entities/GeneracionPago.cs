using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class GeneracionPago
{
    [Key]
    public int idPago { get; set; }

    public int? idtercero { get; set; }

    public int? idFormapago { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechayHora { get; set; }

    public int? idBanco { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorTotalPagar { get; set; }

    public string? Concepto { get; set; }

    public bool? anular { get; set; }

    public int? idusuarioanula { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaanula { get; set; }

    public int? idusuariopago { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechapago { get; set; }

    [Column(TypeName = "money")]
    public decimal? descuento { get; set; }

    public bool? plano { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? tipodscto { get; set; }

    public bool? sincronizada { get; set; }
}
