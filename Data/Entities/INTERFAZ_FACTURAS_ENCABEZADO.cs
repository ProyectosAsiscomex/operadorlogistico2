using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class INTERFAZ_FACTURAS_ENCABEZADO
{
    [StringLength(50)]
    public string? NROFACTURA { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FECHA { get; set; }

    [StringLength(4000)]
    public string? PLANO { get; set; }
}
