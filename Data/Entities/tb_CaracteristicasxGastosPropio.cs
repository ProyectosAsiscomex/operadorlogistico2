using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class tb_CaracteristicasxGastosPropio
{
    [Key]
    public int id { get; set; }

    public int? idServicio { get; set; }

    public int? idCausacion { get; set; }

    [ForeignKey("idServicio")]
    [InverseProperty("tb_CaracteristicasxGastosPropios")]
    public virtual Servicio? idServicioNavigation { get; set; }
}
