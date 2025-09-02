using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ProcesoAnticipoDetalle")]
public partial class ProcesoAnticipoDetalle
{
    [Key]
    public int idProcesoAnticipoDetalle { get; set; }

    public int? idProcesoAnticipo { get; set; }

    public int? idGasto { get; set; }

    [ForeignKey("idGasto")]
    [InverseProperty("ProcesoAnticipoDetalles")]
    public virtual Gasto? idGastoNavigation { get; set; }

    [ForeignKey("idProcesoAnticipo")]
    [InverseProperty("ProcesoAnticipoDetalles")]
    public virtual ProcesoAnticipo? idProcesoAnticipoNavigation { get; set; }
}
