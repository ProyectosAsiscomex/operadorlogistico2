using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class LugarIngresoMercancia
{
    [Key]
    public int idLugarIngresoMercancias { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoDane { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigodim { get; set; }

    public bool? tipo { get; set; }

    public bool? activo { get; set; }

    [InverseProperty("idLugarIngresoMercanciasNavigation")]
    public virtual ICollection<CiudadesAduanimex> CiudadesAduanimexes { get; set; } = new List<CiudadesAduanimex>();

    [InverseProperty("idLugarIngresoMercanciasNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; } = new List<ReciboCajaAnticipo>();

    [InverseProperty("idCiudadNavigation")]
    public virtual ICollection<ReciboCajaMenor> ReciboCajaMenors { get; set; } = new List<ReciboCajaMenor>();
}
