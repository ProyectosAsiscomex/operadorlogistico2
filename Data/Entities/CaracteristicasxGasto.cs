using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class CaracteristicasxGasto
{
    [Key]
    public int idCaracteristicasxGastos { get; set; }

    public int? idGasto { get; set; }

    public int? idCausacion { get; set; }

    [ForeignKey("idCausacion")]
    [InverseProperty("CaracteristicasxGastos")]
    public virtual Causacione? idCausacionNavigation { get; set; }

    [ForeignKey("idGasto")]
    [InverseProperty("CaracteristicasxGastos")]
    public virtual Gasto? idGastoNavigation { get; set; }
}
