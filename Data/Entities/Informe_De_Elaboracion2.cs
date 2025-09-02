using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Informe_De_Elaboracion2
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [StringLength(200)]
    public string? estado { get; set; }

    [Column("Fecha Levante", TypeName = "smalldatetime")]
    public DateTime? Fecha_Levante { get; set; }

    [Column("Fecha Creacion", TypeName = "smalldatetime")]
    public DateTime? Fecha_Creacion { get; set; }

    [Column("Nro Declaraciones de Importacion")]
    public int? Nro_Declaraciones_de_Importacion { get; set; }

    [Column("Nro Andinas del Valor")]
    public int? Nro_Andinas_del_Valor { get; set; }

    [Column("Usuario Elabora Declaraciones")]
    [StringLength(803)]
    public string? Usuario_Elabora_Declaraciones { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idUsuario { get; set; }

    public int? SedeOperativa { get; set; }
}
