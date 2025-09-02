using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class ValidacionIndicadore
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDO { get; set; }

    [Column("Indicador que no se logra generar")]
    [StringLength(1019)]
    public string? Indicador_que_no_se_logra_generar { get; set; }

    [Column("Fecha no diligenciada")]
    [StringLength(53)]
    [Unicode(false)]
    public string Fecha_no_diligenciada { get; set; } = null!;
}
