using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("GastoAnticipo")]
public partial class GastoAnticipo
{
    [Key]
    public int idGastoAnticipo { get; set; }

    public int? idAnticipo { get; set; }

    public int? idProceso { get; set; }

    public int? idGasto { get; set; }

    [Column(TypeName = "money")]
    public decimal? Valor { get; set; }

    public int? idCausacionItems { get; set; }

    [ForeignKey("idAnticipo")]
    [InverseProperty("GastoAnticipos")]
    public virtual Anticipo? idAnticipoNavigation { get; set; }

    [ForeignKey("idCausacionItems")]
    [InverseProperty("GastoAnticipos")]
    public virtual causacionesitem? idCausacionItemsNavigation { get; set; }

    [ForeignKey("idGasto")]
    [InverseProperty("GastoAnticipos")]
    public virtual Gasto? idGastoNavigation { get; set; }

    [ForeignKey("idProceso")]
    [InverseProperty("GastoAnticipos")]
    public virtual ProcesoAnticipo? idProcesoNavigation { get; set; }
}
