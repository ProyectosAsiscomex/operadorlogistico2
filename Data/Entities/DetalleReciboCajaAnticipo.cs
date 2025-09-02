using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleReciboCajaAnticipo")]
public partial class DetalleReciboCajaAnticipo
{
    [Key]
    public int idDetalleReciboCajaAnticipo { get; set; }

    public int? idReciboCajaAnticipo { get; set; }

    public int? idAnticipo { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorPagado { get; set; }

    [ForeignKey("idAnticipo")]
    [InverseProperty("DetalleReciboCajaAnticipos")]
    public virtual Anticipo? idAnticipoNavigation { get; set; }

    [ForeignKey("idReciboCajaAnticipo")]
    [InverseProperty("DetalleReciboCajaAnticipos")]
    public virtual ReciboCajaAnticipo? idReciboCajaAnticipoNavigation { get; set; }
}
