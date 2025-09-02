using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ProcesoGastoAnticipo")]
public partial class ProcesoGastoAnticipo
{
    [Key]
    public int idProcesoGastoAnticipo { get; set; }

    public int? idAnticipo { get; set; }

    public int? idProceso { get; set; }

    [ForeignKey("idAnticipo")]
    [InverseProperty("ProcesoGastoAnticipos")]
    public virtual Anticipo? idAnticipoNavigation { get; set; }

    [ForeignKey("idProceso")]
    [InverseProperty("ProcesoGastoAnticipos")]
    public virtual ProcesoAnticipo? idProcesoNavigation { get; set; }
}
