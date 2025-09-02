using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("GastoPropioAdicionalAnticipo")]
public partial class GastoPropioAdicionalAnticipo
{
    [Key]
    public int idGastoPropioAdicionalAnticipo { get; set; }

    public int? idAnticipo { get; set; }

    public int? idGasto { get; set; }

    public int? Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorTotal { get; set; }

    [ForeignKey("idAnticipo")]
    [InverseProperty("GastoPropioAdicionalAnticipos")]
    public virtual Anticipo? idAnticipoNavigation { get; set; }

    [ForeignKey("idGasto")]
    [InverseProperty("GastoPropioAdicionalAnticipos")]
    public virtual Servicio? idGastoNavigation { get; set; }
}
