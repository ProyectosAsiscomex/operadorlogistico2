using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Madecentro_GastosDetalle
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [Column("Nro Factura")]
    [StringLength(50)]
    public string? Nro_Factura { get; set; }

    public string? Concepto { get; set; }

    [StringLength(30)]
    public string? Valor { get; set; }

    [StringLength(30)]
    public string? IVA { get; set; }
}
