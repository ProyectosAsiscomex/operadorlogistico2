using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AlertasCorreosConfiguracion")]
public partial class AlertasCorreosConfiguracion
{
    [Key]
    public int idConfiguracion { get; set; }

    [StringLength(200)]
    public string? servidor { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }

    [StringLength(200)]
    public string? password { get; set; }

    [StringLength(50)]
    public string? puerto { get; set; }

    public bool? ssl { get; set; }

    [StringLength(50)]
    public string? timeout { get; set; }

    public bool? disparosemanal { get; set; }

    public bool? disparomensual { get; set; }

    public int? consecutivodisparo { get; set; }

    [StringLength(200)]
    public string? cadenaconexion { get; set; }

    [StringLength(200)]
    public string? servidoraplicacion { get; set; }

    [StringLength(200)]
    public string? nombreaplicacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? rutaimagines { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? basedatosmuisca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? basedatostranscriptor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? usuarioaccesotranscriptor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? passwordaccesotranscriptor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? passwordaccesomuisca { get; set; }

    public short? opcionesdesincronizaciondatos { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ultimasincronizacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? usuarioaccesomuisca { get; set; }

    [StringLength(500)]
    public string? encabezadocorreos { get; set; }

    [StringLength(500)]
    public string? piecorreos { get; set; }

    [StringLength(200)]
    public string? correofrom { get; set; }

    [StringLength(500)]
    public string? destinatarioprovisionales { get; set; }

    [StringLength(500)]
    public string? destinatariotemporales { get; set; }

    public bool? solocrearsaemediantedo { get; set; }

    public bool? declaracionesexportaciondefinitiva { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? rutainterface { get; set; }
}
