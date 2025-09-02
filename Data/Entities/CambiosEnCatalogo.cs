using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("CambiosEnCatalogo")]
public partial class CambiosEnCatalogo
{
    public int idcambio { get; set; }

    public int? idproducto { get; set; }

    [Unicode(false)]
    public string? valorAnterior { get; set; }

    [Unicode(false)]
    public string? valorNuevo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? campoAfectado { get; set; }

    public bool? corregida { get; set; }

    public bool? NoNecesitaCorregir { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Observacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaModificacion { get; set; }

    public int? idUsuarioModifica { get; set; }
}
