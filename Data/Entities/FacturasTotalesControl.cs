using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class FacturasTotalesControl
{
    [StringLength(50)]
    public string? DO { get; set; }

    [StringLength(50)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechavence { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [Column("Importador/Exportador")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Importador_Exportador { get; set; }

    public string? concepto { get; set; }

    public string? anexo { get; set; }

    [Column(TypeName = "money")]
    public decimal? terceros { get; set; }

    [Column(TypeName = "money")]
    public decimal? propios { get; set; }

    [Column(TypeName = "money")]
    public decimal? iva16 { get; set; }

    [Column(TypeName = "money")]
    public decimal? anticipos { get; set; }

    [Column(TypeName = "money")]
    public decimal? reteiva15 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? pedido { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasacambio { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [StringLength(20)]
    public string? usuario { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacreacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechamodificacion { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string anulada { get; set; } = null!;
}
