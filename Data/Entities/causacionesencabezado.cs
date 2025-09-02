using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("causacionesencabezado")]
public partial class causacionesencabezado
{
    [Key]
    public int idcausacion { get; set; }

    public int? iddo { get; set; }

    public int? idtercero { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactrua { get; set; }

    [StringLength(50)]
    public string? plazo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? vence { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorbruto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? reteiva { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? reteica { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? retecree { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valorneto { get; set; }

    public int? idimportador { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [Column(TypeName = "money")]
    public decimal? ReteFuente { get; set; }

    public string? observaciones { get; set; }

    public bool? autorizacionpago { get; set; }

    public bool? pagadototal { get; set; }

    public bool? pagadoparcial { get; set; }

    public int? usuarioautoriza { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? autorizacionpagofecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pagadototalfecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pagadoparcialfecha { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FormaPago { get; set; }

    public int? idUsuario { get; set; }

    public bool? Anulado { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? MotivoAnulacion { get; set; }

    public int? idBanco { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? Nota { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? descuentos { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? intereses { get; set; }

    public bool? confirmado { get; set; }

    public bool? control { get; set; }

    public bool? DebitoAutomatico { get; set; }

    public int? sindo { get; set; }

    public bool? control2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fechaCierre { get; set; }

    public bool? amx { get; set; }

    public bool? notacredito { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? tasa { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? trm { get; set; }

    public bool? im { get; set; }

    public bool? ia { get; set; }

    public bool? ai { get; set; }

    public bool? ae { get; set; }

    public bool? em { get; set; }

    public bool? ea { get; set; }

    public bool? tn { get; set; }

    public bool? tm { get; set; }

    public bool? os { get; set; }

    public bool? inn { get; set; }

    public bool? sincronizada { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? DepositoRecibido { get; set; }

    [Unicode(false)]
    public string? DepositoObservaciones { get; set; }

    public int? idmoneda { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrocontabilidad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? numerocontable { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorpagoreal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nrocontabledeposito { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCausacion { get; set; }

    [ForeignKey("idBanco")]
    [InverseProperty("causacionesencabezados")]
    public virtual Banco? idBancoNavigation { get; set; }

    [ForeignKey("idUsuario")]
    [InverseProperty("causacionesencabezados")]
    public virtual usuario? idUsuarioNavigation { get; set; }
}
