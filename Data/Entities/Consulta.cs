using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Consulta
{
    [Key]
    public int idconsulta { get; set; }

    public int? idusuario { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombreconsulta { get; set; }

    [Unicode(false)]
    public string? query { get; set; }

    [Unicode(false)]
    public string? indicequery { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaquery { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? rutagenerado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharutagenerado { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    public byte? ranking { get; set; }

    public bool? bloqueado { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? operacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainicial { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafinal { get; set; }

    [Unicode(false)]
    public string? namecolumnas { get; set; }

    [Unicode(false)]
    public string? aliascolumnas { get; set; }

    [Unicode(false)]
    public string? namecondicionales { get; set; }

    [Unicode(false)]
    public string? datoscondicionales { get; set; }
}
