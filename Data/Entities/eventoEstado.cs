using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("eventoEstado")]
public partial class eventoEstado
{
    [Key]
    public int idEventoEstado { get; set; }

    public int? idOrden { get; set; }

    public int? idEntrega { get; set; }

    public int? idEstado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fPropuesta { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaReal { get; set; }

    public int? idTercero { get; set; }

    public string? cObservaciones { get; set; }

    [StringLength(100)]
    public string? despacho { get; set; }

    public int? idcategoria { get; set; }

    public int? diasduracion { get; set; }

    public int? posicion { get; set; }
}
