using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class CalificacionProveedoresDetalle
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column("Fecha Creacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Creacion { get; set; }

    [Column("Fecha Cierre")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_Cierre { get; set; }

    [StringLength(100)]
    public string? Proveedor { get; set; }

    [Column("Cumplimiento Llegada")]
    [Unicode(false)]
    public string? Cumplimiento_Llegada { get; set; }

    [Column("Factura a tiempo")]
    [Unicode(false)]
    public string? Factura_a_tiempo { get; set; }

    [Column("HAWB a tiempo")]
    [Unicode(false)]
    public string? HAWB_a_tiempo { get; set; }

    [Column("Liberacion a tiempo")]
    [Unicode(false)]
    public string? Liberacion_a_tiempo { get; set; }

    [Column("Reportes Oportunos")]
    [Unicode(false)]
    public string? Reportes_Oportunos { get; set; }

    [Column("Respuesta Oportuna")]
    [Unicode(false)]
    public string? Respuesta_Oportuna { get; set; }

    [Column("Notificacion Novedades")]
    [Unicode(false)]
    public string? Notificacion_Novedades { get; set; }
}
