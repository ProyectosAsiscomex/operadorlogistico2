using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("generacionPagoDetalleCliente")]
public partial class generacionPagoDetalleCliente
{
    [Key]
    public int idGeneracionPagoDet { get; set; }

    public int? dGeneracionPago { get; set; }

    public int? idFactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    public int? idnota { get; set; }
}
