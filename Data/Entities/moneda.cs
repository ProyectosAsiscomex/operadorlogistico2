using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class moneda
{
    [Key]
    public int idmoneda { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(100)]
    public string? descripcion { get; set; }

    [StringLength(10)]
    public string? codigoimportaciones { get; set; }

    [StringLength(30)]
    public string? descripcionimportaciones { get; set; }

    [InverseProperty("idMonedaNavigation")]
    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    [InverseProperty("Modena")]
    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();
}
