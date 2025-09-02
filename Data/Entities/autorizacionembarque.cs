using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("autorizacionembarque")]
public partial class autorizacionembarque
{
    [Key]
    public int idautorizacionembarque { get; set; }

    public int? idexportador { get; set; }

    public int? iddeclarante { get; set; }

    public int? iddestinatario { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroformulario { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nroformularioanterior { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nroreferencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nroautorizacionglobal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroprogramaMSVC { get; set; }

    public int? idregimenaduanero { get; set; }

    public int? idaduanadespacho { get; set; }

    public int? idregionprocedencia { get; set; }

    public int? idtipoembarque { get; set; }

    public int? idtipodatos { get; set; }

    public int? idnaturalezatransaccion { get; set; }

    public int? idtiposolicitud { get; set; }

    public int? idincoterm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? lugarentrega { get; set; }

    public int? idmoneda { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? valorfactura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tasacambio { get; set; }

    public int? idformapago { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cantidadpagosanticipados { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaprimerpagoanti { get; set; }

    public bool? mciamanoviajero { get; set; }

    public bool? sistemasespeciales { get; set; }

    public bool? exportacionentransito { get; set; }

    public bool? mciazonaprimaria { get; set; }

    public int? idmodotransporte { get; set; }

    public int? idtipocarga { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroviaje { get; set; }

    public int? idaduanasalida { get; set; }

    public int? idlugarembarque { get; set; }

    public int? idpais { get; set; }

    public int? idlugardestino { get; set; }

    public int? idlugardestinofinalcol { get; set; }

    public int? iddepositohabilitado { get; set; }

    public int? idtransportador { get; set; }

    public int? idlugarinspeccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nroaprovacioninspeccion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dirreccionubicacionmcia { get; set; }

    public bool? solicitainspeccionfisica { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Vtotalfletes { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Vtotalseguros { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Vtotalotrosgastos { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Valorreintegrar { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nroradicado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? sedeoperativa { get; set; }

    public int? nroEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UltimaModificacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DexDefinitivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDexDefinitivo { get; set; }

    public int? idtipodeoperacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EstadoSAE { get; set; }

    public short? idUsuarioDigitator { get; set; }

    public short? idUsuarioRevisor { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaAceptacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? origenSAE { get; set; }

    [StringLength(100)]
    public string? sededigitadora { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaautorizacion { get; set; }

    [StringLength(50)]
    public string? DexProvisional { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDexProvisional { get; set; }

    public bool? AdjuntoDocumento { get; set; }
}
