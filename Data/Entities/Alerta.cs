using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Alerta
{
    [Key]
    public int IdAlerta { get; set; }

    public int? IdUsuario { get; set; }

    [StringLength(200)]
    public string? TituloAlerta { get; set; }

    [StringLength(200)]
    public string? Referencia { get; set; }

    [StringLength(200)]
    public string? Origen { get; set; }

    [StringLength(700)]
    public string? Descripcion { get; set; }

    public int? IdGrupo { get; set; }

    public int? DiasVerde { get; set; }

    public int? DiasRojo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha1 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha2 { get; set; }

    public bool? ReportarUsuarios { get; set; }

    public bool? Activada { get; set; }

    public bool? ExigirComentario { get; set; }

    public bool? AfectarPendiente { get; set; }

    public int? idAlertaRecurrente { get; set; }

    public int? semana { get; set; }

    public int? mes { get; set; }
}
