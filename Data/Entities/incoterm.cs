using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("incoterm")]
public partial class incoterm
{
    [Key]
    public int idincoterm { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(100)]
    public string? descripcion { get; set; }

    [InverseProperty("Incoterm")]
    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();
}
