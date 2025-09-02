using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Gasto
{
    [Key]
    public int idGasto { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [Column("Gasto")]
    [StringLength(200)]
    public string? Gasto1 { get; set; }

    [StringLength(200)]
    public string? Contabilidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    public bool? documento { get; set; }

    public int? idmoneda { get; set; }

    public int? idGastoConcepto { get; set; }

    public int? idvalordefecto { get; set; }

    public bool? servicioaduana { get; set; }

    [StringLength(100)]
    public string? tipofacturacion { get; set; }

    public bool? contabilizar { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idtipo { get; set; }

    public string? gastocalculo { get; set; }

    public string? gastomascara { get; set; }

    public int? Tipo { get; set; }

    public bool? Formas { get; set; }

    public bool? ChequeRecibo { get; set; }

    public bool? Anticipos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InicialNal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaxPagarNal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Naturaleza { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Referencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InicialExt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaxPagarExt { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PORIVA { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PorRetencionComun { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PorRetencionSimp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaContComun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CuentaContSimp { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Base { get; set; }

    public bool? CuentaManejaProy { get; set; }

    public bool? Importacion { get; set; }

    public bool? Exportacion { get; set; }

    public bool? Dta { get; set; }

    public bool? AgentCarga { get; set; }

    public bool? Bodegaje { get; set; }

    public int? idservicio { get; set; }

    public bool? habilitado { get; set; }

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<CaracteristicasxGasto> CaracteristicasxGastos { get; set; } = new List<CaracteristicasxGasto>();

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<DetalleReciboCajaMenor> DetalleReciboCajaMenors { get; set; } = new List<DetalleReciboCajaMenor>();

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<GastoAnticipo> GastoAnticipos { get; set; } = new List<GastoAnticipo>();

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<ProcesoAnticipoDetalle> ProcesoAnticipoDetalles { get; set; } = new List<ProcesoAnticipoDetalle>();

    [InverseProperty("idGastoNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; } = new List<ReciboCajaAnticipo>();
}
