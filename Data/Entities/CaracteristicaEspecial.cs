using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CaracteristicaEspecial")]
public partial class CaracteristicaEspecial
{
    [Key]
    public int IdCaracteristica { get; set; }

    public int? Orden { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FormaActualizacion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [InverseProperty("idcaracteristicaespecialNavigation")]
    public virtual ICollection<ChequeoEspesial> ChequeoEspesials { get; set; } = new List<ChequeoEspesial>();
}
