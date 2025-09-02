using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Preliquidacion")]
public partial class Preliquidacion
{
    [Key]
    public int idPreliquidacion { get; set; }

    [StringLength(100)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public int? idtercero { get; set; }

    [StringLength(50)]
    public string? tipo { get; set; }

    public int? idconcepto { get; set; }

    [StringLength(300)]
    public string? concepto { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [Column(TypeName = "money")]
    public decimal? iva { get; set; }

    [Column(TypeName = "money")]
    public decimal? retencion { get; set; }

    public string? observacion { get; set; }

    public int? idDo { get; set; }
}
