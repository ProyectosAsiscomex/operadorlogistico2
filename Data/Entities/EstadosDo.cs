using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class EstadosDo
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column("Fecha Creación", TypeName = "smalldatetime")]
    public DateTime? Fecha_Creación { get; set; }

    [StringLength(200)]
    public string? Estado { get; set; }

    [Column("Nombre Servicio")]
    [StringLength(1000)]
    public string? Nombre_Servicio { get; set; }

    [Column("Nombre Comercial")]
    [StringLength(803)]
    public string Nombre_Comercial { get; set; } = null!;

    [Column("Nombre Operativo")]
    [StringLength(803)]
    public string Nombre_Operativo { get; set; } = null!;
}
