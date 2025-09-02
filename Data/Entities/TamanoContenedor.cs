using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TamanoContenedor")]
public partial class TamanoContenedor
{
    [Key]
    public int idtamanocontenedor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? tara { get; set; }

    [InverseProperty("idTamanoContenedorNavigation")]
    public virtual ICollection<ContenedorAnticipo> ContenedorAnticipos { get; set; } = new List<ContenedorAnticipo>();
}
