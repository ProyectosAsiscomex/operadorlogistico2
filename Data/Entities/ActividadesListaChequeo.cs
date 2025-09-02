using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ActividadesListaChequeo")]
public partial class ActividadesListaChequeo
{
    [Key]
    public int idActividadesListaChequeo { get; set; }

    public int? idActividad { get; set; }

    public int? idListaChequeoEncabezado { get; set; }

    public bool? Uso { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Observaciones { get; set; }

    [ForeignKey("idActividad")]
    [InverseProperty("ActividadesListaChequeos")]
    public virtual Actividade? idActividadNavigation { get; set; }

    [ForeignKey("idListaChequeoEncabezado")]
    [InverseProperty("ActividadesListaChequeos")]
    public virtual ListaChequeoEncabezado? idListaChequeoEncabezadoNavigation { get; set; }
}
