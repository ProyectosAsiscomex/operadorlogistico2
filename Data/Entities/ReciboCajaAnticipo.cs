using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ReciboCajaAnticipo")]
public partial class ReciboCajaAnticipo
{
    [Key]
    public int idReciboCajaAnticipo { get; set; }

    public int? idCliente { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReciboNumero { get; set; }

    public int? idBanco { get; set; }

    [Column(TypeName = "money")]
    public decimal? Valor { get; set; }

    public int? idFormaPago { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocumentoNumero { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Entidad { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Observacion { get; set; }

    public bool? Traslado { get; set; }

    public int? idBancoTraslado { get; set; }

    public bool? GenerarCredito { get; set; }

    public int? TipoRecibo { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteIva { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteFuente { get; set; }

    [Column(TypeName = "money")]
    public decimal? Reteica { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CuentaOtroConcepto { get; set; }

    public bool? DevolucionDeposito { get; set; }

    public int? idDoOtroConcepto { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    public int? idLugarIngresoMercancias { get; set; }

    public bool? Anulado { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? MotivoAnulacion { get; set; }

    public int? idTercero { get; set; }

    public int? idGasto { get; set; }

    public int? residuo { get; set; }

    public int? idfactura { get; set; }

    public bool? sincronizada { get; set; }

    [InverseProperty("idReciboCajaAnticipoNavigation")]
    public virtual ICollection<DetalleReciboCajaAnticipo> DetalleReciboCajaAnticipos { get; set; } = new List<DetalleReciboCajaAnticipo>();

    [InverseProperty("idReciboCajaAnticipoNavigation")]
    public virtual ICollection<FacturaReciboCaja> FacturaReciboCajas { get; set; } = new List<FacturaReciboCaja>();

    [ForeignKey("idBanco")]
    [InverseProperty("ReciboCajaAnticipoidBancoNavigations")]
    public virtual Banco? idBancoNavigation { get; set; }

    [ForeignKey("idBancoTraslado")]
    [InverseProperty("ReciboCajaAnticipoidBancoTrasladoNavigations")]
    public virtual Banco? idBancoTrasladoNavigation { get; set; }

    [ForeignKey("idCliente")]
    [InverseProperty("ReciboCajaAnticipos")]
    public virtual exportador? idClienteNavigation { get; set; }

    [ForeignKey("idDoOtroConcepto")]
    [InverseProperty("ReciboCajaAnticipos")]
    public virtual DO? idDoOtroConceptoNavigation { get; set; }

    [ForeignKey("idFormaPago")]
    [InverseProperty("ReciboCajaAnticipos")]
    public virtual FormaPagoRecibo? idFormaPagoNavigation { get; set; }

    [ForeignKey("idGasto")]
    [InverseProperty("ReciboCajaAnticipos")]
    public virtual Gasto? idGastoNavigation { get; set; }

    [ForeignKey("idLugarIngresoMercancias")]
    [InverseProperty("ReciboCajaAnticipos")]
    public virtual LugarIngresoMercancia? idLugarIngresoMercanciasNavigation { get; set; }

    [ForeignKey("idTercero")]
    [InverseProperty("ReciboCajaAnticipos")]
    public virtual Tercero? idTerceroNavigation { get; set; }
}
