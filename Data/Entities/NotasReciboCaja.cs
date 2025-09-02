using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("NotasReciboCaja")]
public partial class NotasReciboCaja
{
    [Key]
    public int idNotaReciboCaja { get; set; }

    public int? idNota { get; set; }

    public int? idReciboCaja { get; set; }

    public int? idReciboCajaAnticipo { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorBruto { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteIva { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteFuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteIca { get; set; }

    [Column(TypeName = "money")]
    public decimal? Recibido { get; set; }
}
