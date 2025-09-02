using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("GeneracionPagoDetalle")]
public partial class GeneracionPagoDetalle
{
    [Key]
    public int idGeneracionPagoDet { get; set; }

    public int? idGeneracionPago { get; set; }

    public int? idcausacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    public int? idfactura { get; set; }

    public int? idnota { get; set; }

    public bool? anular { get; set; }
}
