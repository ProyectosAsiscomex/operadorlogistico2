using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ChequeoEspesial")]
public partial class ChequeoEspesial
{
    [Key]
    public int idChequeoEspesial { get; set; }

    public int? idListaChequeoEncabezado { get; set; }

    public int? idcaracteristicaespecial { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Otro { get; set; }

    [ForeignKey("idListaChequeoEncabezado")]
    [InverseProperty("ChequeoEspesials")]
    public virtual ListaChequeoEncabezado? idListaChequeoEncabezadoNavigation { get; set; }

    [ForeignKey("idcaracteristicaespecial")]
    [InverseProperty("ChequeoEspesials")]
    public virtual CaracteristicaEspecial? idcaracteristicaespecialNavigation { get; set; }
}
