using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Servicio
{
    [Key]
    public int idServicio { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [Column("Servicio")]
    [StringLength(200)]
    public string? Servicio1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? idtipo { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Porcentaje { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Tarifa { get; set; }

    [Column("base")]
    public int? _base { get; set; }

    [Unicode(false)]
    public string? grupo_tipo { get; set; }

    [Unicode(false)]
    public string? grupo_liquidacion { get; set; }

    public bool? importacion { get; set; }

    public bool? exportacion { get; set; }

    public bool? dta { get; set; }

    public bool? vucefuce { get; set; }

    public int? TipoDocumento { get; set; }

    public bool? Formas { get; set; }

    public bool? Cheque_recibo { get; set; }

    public bool? Anticipos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Inicial_Nal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaxPagar_Nal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Naturaleza { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Referencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Inicial_Ext { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaxPagar_Ext { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PORIVA { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PorRetencion_comun { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PorRetencion_Simp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaCont_comun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaCont_Simp { get; set; }

    public bool? CuentaManejaProy { get; set; }

    public bool? IM { get; set; }

    public bool? IA { get; set; }

    public bool? AI { get; set; }

    public bool? AE { get; set; }

    public bool? EM { get; set; }

    public bool? EA { get; set; }

    public bool? TN { get; set; }

    public bool? TI { get; set; }

    public bool? OS { get; set; }

    public int? idGasto { get; set; }

    public bool? habilitado { get; set; }

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<GastoPropioAdicionalAnticipo> GastoPropioAdicionalAnticipos { get; set; } = new List<GastoPropioAdicionalAnticipo>();

    [InverseProperty("idServicioNavigation")]
    public virtual ICollection<tb_CaracteristicasxGastosPropio> tb_CaracteristicasxGastosPropios { get; set; } = new List<tb_CaracteristicasxGastosPropio>();
}
