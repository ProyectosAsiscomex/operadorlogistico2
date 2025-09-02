using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("modotransporte")]
public partial class modotransporte
{
    [Key]
    public int idmodotransporte { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [InverseProperty("ViaNavigation")]
    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();
}
