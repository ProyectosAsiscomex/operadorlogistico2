using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("lugarembarque")]
public partial class lugarembarque
{
    [Key]
    public int idlugarembarque { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idpais { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipo { get; set; }

    public int? idaduana { get; set; }

    [InverseProperty("idPuertoNavigation")]
    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();
}
