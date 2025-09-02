using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tipodeoperacion")]
public partial class tipodeoperacion
{
    [Key]
    public int idtipodeoperacion { get; set; }

    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? descripcion { get; set; }

    [InverseProperty("TipoOperacion")]
    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();
}
