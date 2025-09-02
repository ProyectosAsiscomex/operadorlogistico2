using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Causacione
{
    [Key]
    public int idCausacion { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    public string? Causacion { get; set; }

    public bool? inn { get; set; }

    [InverseProperty("idCausacionNavigation")]
    public virtual ICollection<CaracteristicasxGasto> CaracteristicasxGastos { get; set; } = new List<CaracteristicasxGasto>();
}
