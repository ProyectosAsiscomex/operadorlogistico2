using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ProcesoAnticipo")]
public partial class ProcesoAnticipo
{
    [Key]
    public int idProcesoAnticipo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [InverseProperty("idProcesoNavigation")]
    public virtual ICollection<GastoAnticipo> GastoAnticipos { get; set; } = new List<GastoAnticipo>();

    [InverseProperty("idProcesoAnticipoNavigation")]
    public virtual ICollection<ProcesoAnticipoDetalle> ProcesoAnticipoDetalles { get; set; } = new List<ProcesoAnticipoDetalle>();

    [InverseProperty("idProcesoNavigation")]
    public virtual ICollection<ProcesoGastoAnticipo> ProcesoGastoAnticipos { get; set; } = new List<ProcesoGastoAnticipo>();
}
