using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturaImportacion")]
public partial class FacturaImportacion
{
    [Key]
    public int idfacturaimportacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? auxiliar { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechavencimiento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroproforma { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaproforma { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodoctransporte { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadoctransporte { get; set; }

    public int? idproveedor { get; set; }

    public int? idimportador { get; set; }

    public int? idmoneda { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? trm { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? tasa { get; set; }

    [Column(TypeName = "money")]
    public decimal? flete { get; set; }

    [Column(TypeName = "money")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "money")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? valortotal { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesoreal { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pagado { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? saldo { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? nrodepiezas { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? piezasreales { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? volumenneto { get; set; }

    [StringLength(700)]
    [Unicode(false)]
    public string? detalleobservacion { get; set; }

    [StringLength(30)]
    public string? DocumentoOperativo { get; set; }

    public int? idincoterm { get; set; }

    [Column(TypeName = "money")]
    public decimal? valortotalfob { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalcifpesos { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalfobpesos { get; set; }

    public int? idpaisdestino { get; set; }

    public int? idlugardestino { get; set; }

    public int? idpaisorigen { get; set; }

    public int? idpaiscompra { get; set; }

    public int? idlugarembarque { get; set; }

    public int? cmbidpais { get; set; }

    public int? idvia { get; set; }

    [Column(TypeName = "money")]
    public decimal? inland { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastosorigen { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalfactura { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? registro { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharegistro { get; set; }

    [Column(TypeName = "money")]
    public decimal? vltotalfacturaotramoneda { get; set; }

    public int? idlugaringmercancia { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? valorincoterm { get; set; }

    public int? idformapago { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? lugarexterior { get; set; }

    public bool? prorrateo { get; set; }

    public bool? prorrateoFob { get; set; }

    public bool? prorrateoFCA { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? valortotalfactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_95 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_98 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_100 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_102 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_104 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_106 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_108 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_110 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_112 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_124 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_130 { get; set; }

    [Column(TypeName = "money")]
    public decimal? valordescuento { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? pordescuento { get; set; }

    public bool? aplicafobdecla { get; set; }

    public bool? aplicaajustedecla { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_126 { get; set; }

    public int? IDLISTACHEQUEO { get; set; }

    public int? nroProducto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? derechosaduana { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? gastosdestino { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? tipocontratoodocumento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? numcontratoodocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadg4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorcontratoodocumento { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? codigonaturalezatransaccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idcodformaenvio { get; set; }

    public bool? existeintermediacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipoIntermedacion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Especifiqueintermediacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? otrosapellidos { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? otrosnombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? razonsocialintemediario { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? direccionIntermed { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ciudadIntermed { get; set; }

    public bool? existenrestricciones { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? idcodtiporestriccion { get; set; }

    public int? existenrestriccionesocontraprestaciones { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? especifiquecodtipocondicionocontraprestacion { get; set; }

    public bool? puededeterminarse { get; set; }

    public bool? existencanonesderechoslicencia { get; set; }

    public bool? existenreversionesalvendedor { get; set; }

    public bool? existevinculacionentrecompradorvendedor { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? idcodtipovinculacion { get; set; }

    public bool? influyevinculacionprecio { get; set; }

    public bool? existenvalorescriterio { get; set; }

    public bool? algunosimportesdeclarados { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Andina_128 { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? sumadofob { get; set; }

    public bool? tiposumaresta { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? ValorTotalMercancia { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? pedido { get; set; }
}
