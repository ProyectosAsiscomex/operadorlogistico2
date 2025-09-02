using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DeclaracionAndinadelValor")]
public partial class DeclaracionAndinadelValor
{
    [Key]
    public int iddeclaandina { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroauxiliar { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaanoauxiliar { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ano { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? numformulario { get; set; }

    public int? idexportador { get; set; }

    public int? idaduana { get; set; }

    [StringLength(100)]
    public string? nrodeclaimpo { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string idtipodecla { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadeclaimpo { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? tipocambio { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? tipocambio2 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechatipocambio2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobtotal { get; set; }

    public int? idintermediario { get; set; }

    [Column(TypeName = "money")]
    public decimal? precionetosegfactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? precionetosegfacturausd { get; set; }

    [Column(TypeName = "money")]
    public decimal? pagosindesretrootros { get; set; }

    [Column(TypeName = "money")]
    public decimal? pagosindesretrootrosuds { get; set; }

    [Column(TypeName = "money")]
    public decimal? precpagadoxpagarusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? comicorreexccomicomp { get; set; }

    [Column(TypeName = "money")]
    public decimal? comicorreexccomicompusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? envasesembalajes { get; set; }

    [Column(TypeName = "money")]
    public decimal? envasesembalajesusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? presmatprimarotros { get; set; }

    [Column(TypeName = "money")]
    public decimal? presmatprimarotrosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? presthermatmoletc { get; set; }

    [Column(TypeName = "money")]
    public decimal? presthermatmoletcusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? prestinsumosotros { get; set; }

    [Column(TypeName = "money")]
    public decimal? prestinsumosotrosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? prestingcreaplaotros { get; set; }

    [Column(TypeName = "money")]
    public decimal? prestingcreaplaotrosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? canonesderlic { get; set; }

    [Column(TypeName = "money")]
    public decimal? canonesderlicusc { get; set; }

    [Column(TypeName = "money")]
    public decimal? productoreventaoutilpos { get; set; }

    [Column(TypeName = "money")]
    public decimal? productoreventaoutilposusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "money")]
    public decimal? segurousd { get; set; }

    [Column(TypeName = "money")]
    public decimal? totaladicionesusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastosentregaposimport { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastosentregaposimportusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? derechosaduaotrosimpuest { get; set; }

    [Column(TypeName = "money")]
    public decimal? derechosaduaotrosimpuestusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? intereses { get; set; }

    [Column(TypeName = "money")]
    public decimal? interesesusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? otrosgastosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? totaldeduccionesusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valortransacciondeclarado { get; set; }

    public int? iddeclaimpo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idcodnivelcomercialcomprador { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? especifiquecodnivelcomercialcomprador { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idcodcondicionvendedor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? especifiquecodcondicionvendedor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nroresolucion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadg2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idcodformaenvio { get; set; }

    public int? idincoterm { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? idlugar { get; set; }

    public int? idcodpaisprocedencia { get; set; }

    public int? idfacturaimpo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadg3 { get; set; }

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

    public int? idcodmonedadg1 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadg5 { get; set; }

    public int? idcodmonedadg2 { get; set; }

    public int? idcodmoneda3 { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? tipocambio3 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechatipocambio3 { get; set; }

    public bool? existeintermediacion { get; set; }

    public bool? existenrestricciones { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? idcodtiporestriccion { get; set; }

    public bool? existenrestriccionesocontraprestaciones { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? codtipocondicionocontraprestacion { get; set; }

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

    [StringLength(300)]
    [Unicode(false)]
    public string? iddeclaracionimportacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadg6 { get; set; }

    public int? lugardeimportacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastostransportemanejoentregaexteriorhastale { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastostransportemanejoentregaexteriorhastaleusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastostransportelehastali { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastostransportelehastaliusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastoscargadescargamanipulacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastoscargadescargamanipulacionusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastosconstruccionarmadoinstalacionmontaje { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastosconstruccionarmadoinstalacionmontajeusd { get; set; }

    public bool? algunosimportesdeclarados { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? numidentificaciontributaria { get; set; }

    public int? dv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? segundoaapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? otrosnombres { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaexpedicion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? idfacturaimpo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idcodigotiporesolucion { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? idcodigonaturalezatransaccion { get; set; }

    public int? iddeclaimportacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipoIntermedacion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Especifiqueintermediacion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? razonsocialintemediario { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? direccionIntermed { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ciudadIntermed { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? primerapellidointermed { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? segundoapellidointermed { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? primernombreintermed { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? otrosnombresintermed { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_difaduana { get; set; }
}
