using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("facturacionaduana")]
public partial class facturacionaduana
{
    [Key]
    public int idfacturacionaduana { get; set; }

    public int? iddo { get; set; }

    public int? idempresa { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaliquidacion { get; set; }

    [StringLength(50)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalfactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? totaliva { get; set; }

    public int? idliquidacionfinal { get; set; }
}
