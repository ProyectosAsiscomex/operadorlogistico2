using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class relacionpago
{
    [StringLength(255)]
    public string? prefijo { get; set; }

    public double? recibo { get; set; }

    [StringLength(255)]
    public string? d_o { get; set; }

    public double? factura { get; set; }

    public double? valor { get; set; }

    public double? recibido { get; set; }

    public double? reteiva { get; set; }

    public double? retefuente { get; set; }

    public double? reteica { get; set; }

    [StringLength(255)]
    public string? prefijo_f { get; set; }

    public double? valorreal { get; set; }
}
