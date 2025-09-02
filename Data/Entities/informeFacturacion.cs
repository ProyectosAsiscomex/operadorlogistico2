using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class informeFacturacion
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Importador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column("Nro Factura")]
    [StringLength(50)]
    public string? Nro_Factura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    [Column("Valor Neto", TypeName = "money")]
    public decimal? Valor_Neto { get; set; }

    [Column("Valor Propios", TypeName = "money")]
    public decimal? Valor_Propios { get; set; }
}
