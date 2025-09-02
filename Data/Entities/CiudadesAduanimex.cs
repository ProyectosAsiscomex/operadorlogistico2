using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CiudadesAduanimex")]
public partial class CiudadesAduanimex
{
    [Key]
    public int idCiudadesAduanimex { get; set; }

    public int? idLugarIngresoMercancias { get; set; }

    public int? idPais { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CentroDeCostos { get; set; }

    public bool? ManejoArchivos { get; set; }

    [Column(TypeName = "money")]
    public decimal? PresupuestoVentas { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Reteica { get; set; }

    public bool? AplicaIndicadores { get; set; }

    public int? CajaArchivo { get; set; }

    public int? ReciboCaja { get; set; }

    public int? ConsecutivoCaja { get; set; }

    public int? ConsecutivoCartas { get; set; }

    public int? ConsecutivosNotas { get; set; }

    [Column(TypeName = "money")]
    public decimal? Base { get; set; }

    public int? ConsecutivoDo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IdentificadorContable { get; set; }

    public long? sindo { get; set; }

    [ForeignKey("idLugarIngresoMercancias")]
    [InverseProperty("CiudadesAduanimexes")]
    public virtual LugarIngresoMercancia? idLugarIngresoMercanciasNavigation { get; set; }

    [ForeignKey("idPais")]
    [InverseProperty("CiudadesAduanimexes")]
    public virtual paise? idPaisNavigation { get; set; }
}
