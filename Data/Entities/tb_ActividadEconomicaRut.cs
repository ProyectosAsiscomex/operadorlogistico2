using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_ActividadEconomicaRut")]
public partial class tb_ActividadEconomicaRut
{
    [Key]
    public int idActividad { get; set; }

    public int? Codigo { get; set; }

    [Unicode(false)]
    public string? Descripcion { get; set; }
}
