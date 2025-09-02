using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class transferenciaCuentum
{
    [Key]
    public int idtransferencia { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public int? idBancoOrigen { get; set; }

    public int? idBancoDestino { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorTraslado { get; set; }

    [StringLength(2000)]
    public string? nota { get; set; }

    public long? consecutivo { get; set; }
}
