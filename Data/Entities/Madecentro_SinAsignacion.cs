using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Madecentro_SinAsignacion
{
    [Column("Fecha Real Llegada")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Real_Llegada { get; set; }

    [Column("Orden de Compra/Pedido")]
    public string Orden_de_Compra_Pedido { get; set; } = null!;

    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    public string? Proveedor { get; set; }

    public string? Mercancia { get; set; }

    [Column("Tipo Carga")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Carga { get; set; }

    [Column("Peso Bruto", TypeName = "decimal(30, 6)")]
    public decimal? Peso_Bruto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Cantidad { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Aduana { get; set; }

    [Column("Fecha Maxima Devolucion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Maxima_Devolucion { get; set; }

    [Column("Fecha Levante")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Levante { get; set; }

    [StringLength(200)]
    public string? Embarcador { get; set; }

    public string? Contenedores { get; set; }
}
