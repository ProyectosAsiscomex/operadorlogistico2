using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class ImputacionesContable
{
    [Key]
    public int idImputacion { get; set; }

    public bool? facturacion { get; set; }

    public bool? recibos { get; set; }

    public bool? egresos { get; set; }

    public bool? Cuentasxpagar { get; set; }

    public bool? Nomina { get; set; }

    public bool? cajamenor { get; set; }

    public bool? traslados { get; set; }

    public bool? transferencia { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorVuce { get; set; }

    public int? iddesde { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ChequeNRO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Desde { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Hasta { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CopiarEn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Archivo { get; set; }

    public bool? Verificardescuadres { get; set; }

    public bool? provisionar { get; set; }
}
