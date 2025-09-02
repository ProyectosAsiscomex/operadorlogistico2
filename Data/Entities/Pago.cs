using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Pago
{
    [Key]
    public int idpago { get; set; }

    public int? idcausacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public int? idusuariopago { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [Column(TypeName = "money")]
    public decimal? descuento { get; set; }

    [Column(TypeName = "money")]
    public decimal? intereses { get; set; }

    [StringLength(100)]
    public string? formapago { get; set; }

    [StringLength(100)]
    public string? nroreferencia { get; set; }

    public int? idbanco { get; set; }

    [StringLength(100)]
    public string? cuentadestino { get; set; }

    public bool? chequegerencia { get; set; }

    public string? nota { get; set; }
}
