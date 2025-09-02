using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("detallefacturaimportacion")]
public partial class detallefacturaimportacion
{
    [Key]
    public int iddetallefacturaimportacion { get; set; }

    public int? idfacturaimpo { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vlunitario { get; set; }

    [Column(TypeName = "money")]
    public decimal? vldescuento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pieza { get; set; }

    public int? numerocaja { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesoneto2 { get; set; }

    public int? idproductosimpo { get; set; }

    public int? idordendecompraitem { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesobruto2 { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesoreal2 { get; set; }

    public int? idarancel { get; set; }

    public int? iddocumentotransporteitem { get; set; }

    public int? iddeclaracionimportacion { get; set; }

    public int? idandinavaloritem { get; set; }

    public int? iddespachoitem { get; set; }

    public int? idregistroimpoitem { get; set; }

    public int? idunidaddian { get; set; }

    [Column(TypeName = "money")]
    public decimal? subtotalitem { get; set; }

    public bool? sistemasespeciales { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vrunitincoterm { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? vrunitinland { get; set; }

    public bool? bRecalculo { get; set; }

    public bool? registro { get; set; }

    public bool? muestrassinvalor { get; set; }

    public int? idpaisOrigen { get; set; }

    public int? idacuerdoComercial { get; set; }

    public int? idModalidad { get; set; }

    public int? idtipoimportacion { get; set; }

    public int? idformaPago { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorDescuento { get; set; }

    [Unicode(false)]
    public string? DescripcionEncabezado { get; set; }

    [Unicode(false)]
    public string? InformaciónAdicional { get; set; }

    [Unicode(false)]
    public string? DescripcionesMinimas { get; set; }

    [Unicode(false)]
    public string? Seriales { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidadfdi { get; set; }

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

    public bool? aplicafobdecla { get; set; }

    public bool? aplicaajustedecla { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? pordescuento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TipoRegistro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroRegistro { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaRegistro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OficinaIncomex { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_descuento { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And95 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And98 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And100 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And102 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And104 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And106 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And108 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And110 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And112 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And124 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_And130 { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? p_pesoneto { get; set; }

    public int? iddeclaracion { get; set; }

    [Column(TypeName = "money")]
    public decimal? Andina_126 { get; set; }

    public bool? antidumping { get; set; }

    public bool? precioRef { get; set; }

    public bool? normaEtiquetado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipoMercancia { get; set; }

    public int? anioTipoMercancia { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrecioTipoMercancia { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? poraran { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? poriva { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ci { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? ajuste { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nrodex { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadex { get; set; }

    public int? idaduanagarantia { get; set; }

    public int? grupo { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_exwfca { get; set; }

    public int? CUOTAS { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_pesobruto { get; set; }

    public int? periodicidad { get; set; }

    public int? nroitem { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_flete { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_seguro { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_otrosg { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_gastoorigen { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_gastodestino { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_sumado { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_inland { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_fletedoctrans { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_otrosgdoctrans { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_diffletes { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? p_fletefac { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? pedido { get; set; }
}
