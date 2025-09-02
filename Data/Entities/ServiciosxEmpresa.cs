using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ServiciosxEmpresa")]
public partial class ServiciosxEmpresa
{
    [Key]
    public int idservicioempresa { get; set; }

    public int? idservicio { get; set; }

    public int? idexportador { get; set; }

    public int? idmoneda { get; set; }

    public short? tipocobro { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idtipo { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? tarifa { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Porcentaje { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Base { get; set; }

    public bool? estado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaModificacion { get; set; }

    public int? idusuario { get; set; }

    public bool? agr_x_maestro { get; set; }

    public bool? importacion { get; set; }

    public bool? exportacion { get; set; }

    public bool? dta { get; set; }

    public bool? requerido { get; set; }

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<GastoPropioAnticipo> GastoPropioAnticipos { get; set; } = new List<GastoPropioAnticipo>();
}
