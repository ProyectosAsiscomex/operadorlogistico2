using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ContenedoresLiquidacion")]
public partial class ContenedoresLiquidacion
{
    [Key]
    public int idLiquidacion { get; set; }

    [StringLength(200)]
    public string? numero { get; set; }

    [StringLength(200)]
    public string? recibo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharecibo { get; set; }

    [StringLength(50)]
    public string? factura { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [StringLength(50)]
    public string? cheque { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorcheque { get; set; }

    [StringLength(300)]
    public string? banco { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechapago { get; set; }
}
