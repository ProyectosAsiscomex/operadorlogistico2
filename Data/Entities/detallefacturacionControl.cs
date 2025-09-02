using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("detallefacturacionControl")]
public partial class detallefacturacionControl
{
    [Key]
    public int iddetalefacturacioncontrol { get; set; }

    public string? nrodo { get; set; }

    public int? item { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? tipo { get; set; }

    public string? detalle { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    public string? nit { get; set; }

    [Column(TypeName = "money")]
    public decimal? iva { get; set; }

    [StringLength(50)]
    public string? factura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }
}
