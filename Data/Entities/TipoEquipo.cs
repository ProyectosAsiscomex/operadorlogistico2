using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class TipoEquipo
{
    [Key]
    public int idtipoequipo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadesde { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fechahasta { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [InverseProperty("idTipoEquipoNavigation")]
    public virtual ICollection<ContenedorAnticipo> ContenedorAnticipos { get; set; } = new List<ContenedorAnticipo>();
}
