using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class informecontenedore
{
    [StringLength(50)]
    [Unicode(false)]
    public string? DO { get; set; }

    [Column("Fecha Creacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Creacion { get; set; }

    [Column("Estado DO")]
    [StringLength(200)]
    public string? Estado_DO { get; set; }

    [Column("Nro Contenedor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Contenedor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TipoEquipo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TamanoContenedor { get; set; }

    [Column("Peso Neto", TypeName = "decimal(30, 6)")]
    public decimal? Peso_Neto { get; set; }

    [Column("Peso Bruto", TypeName = "decimal(30, 6)")]
    public decimal? Peso_Bruto { get; set; }

    [Column("Fecha inicio demoras", TypeName = "smalldatetime")]
    public DateTime? Fecha_inicio_demoras { get; set; }

    [Column("Lugar de Entrega")]
    [StringLength(1000)]
    public string? Lugar_de_Entrega { get; set; }

    [Column("Lugar Devolución")]
    [StringLength(500)]
    public string? Lugar_Devolución { get; set; }
}
