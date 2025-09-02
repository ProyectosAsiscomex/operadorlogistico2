using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("seguimientodespacho")]
public partial class seguimientodespacho
{
    [Key]
    public int idseguimientodespacho { get; set; }

    public int? Iddespacho { get; set; }

    [StringLength(100)]
    public string? Placa { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    public string? remesa { get; set; }
}
