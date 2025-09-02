using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturaReciboCaja")]
public partial class FacturaReciboCaja
{
    [Key]
    public int idFacturaReciboCaja { get; set; }

    public int? idReciboCajaAnticipo { get; set; }

    public int? idFactura { get; set; }

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

    public bool? afectadoretefuente { get; set; }

    [ForeignKey("idFactura")]
    [InverseProperty("FacturaReciboCajas")]
    public virtual Factura? idFacturaNavigation { get; set; }

    [ForeignKey("idReciboCajaAnticipo")]
    [InverseProperty("FacturaReciboCajas")]
    public virtual ReciboCajaAnticipo? idReciboCajaAnticipoNavigation { get; set; }
}
