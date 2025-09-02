using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class PlanoPagosSeleccionCliente
{
    [StringLength(30)]
    [Unicode(false)]
    public string? idpago { get; set; }

    public int idusuariopago { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechapago { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Proveedor { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorTotalPagar { get; set; }
}
