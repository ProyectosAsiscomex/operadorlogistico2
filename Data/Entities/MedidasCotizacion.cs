using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("MedidasCotizacion")]
public partial class MedidasCotizacion
{
    [Key]
    public int Id { get; set; }

    public int? CotizacionId { get; set; }

    public double? Largo { get; set; }

    public double? Alto { get; set; }

    public double? Ancho { get; set; }

    public double? NumeroPiezas { get; set; }

    [Column(TypeName = "money")]
    public decimal? Subtotal { get; set; }

    public int? DetalleMercanciasCotizacionId { get; set; }

    [ForeignKey("CotizacionId")]
    [InverseProperty("MedidasCotizacions")]
    public virtual Cotizacione? Cotizacion { get; set; }
}
