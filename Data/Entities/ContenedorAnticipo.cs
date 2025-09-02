using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ContenedorAnticipo")]
public partial class ContenedorAnticipo
{
    [Key]
    public int idContenedorAnticipo { get; set; }

    public int? idAnticipo { get; set; }

    public int? idTamanoContenedor { get; set; }

    public int? idTipoEquipo { get; set; }

    public int? Cantidad { get; set; }

    [ForeignKey("idAnticipo")]
    [InverseProperty("ContenedorAnticipos")]
    public virtual Anticipo? idAnticipoNavigation { get; set; }

    [ForeignKey("idTamanoContenedor")]
    [InverseProperty("ContenedorAnticipos")]
    public virtual TamanoContenedor? idTamanoContenedorNavigation { get; set; }

    [ForeignKey("idTipoEquipo")]
    [InverseProperty("ContenedorAnticipos")]
    public virtual TipoEquipo? idTipoEquipoNavigation { get; set; }
}
