using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FormaPagoRecibo")]
public partial class FormaPagoRecibo
{
    [Key]
    public int idFormaPagoRecibo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [InverseProperty("idFormaPagoNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; } = new List<ReciboCajaAnticipo>();
}
