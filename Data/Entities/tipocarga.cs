using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tipocarga")]
public partial class tipocarga
{
    [Key]
    public int idtipocarga { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [InverseProperty("TipoCargaNavigation")]
    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    [InverseProperty("idTipoCargaNavigation")]
    public virtual ICollection<ListaChequeoEncabezado> ListaChequeoEncabezados { get; set; } = new List<ListaChequeoEncabezado>();
}
