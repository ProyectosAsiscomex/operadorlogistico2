using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class vPlaneador
{
    [StringLength(85)]
    [Unicode(false)]
    public string? estados { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? mes { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechasolicitudexportacion { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? exportador { get; set; }

    [StringLength(203)]
    [Unicode(false)]
    public string? referencia { get; set; }

    [Unicode(false)]
    public string? tipoproducto { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? mercapeligrosa { get; set; }

    [StringLength(150)]
    public string? embalaje { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? pesobruto { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fecharequeridacliente { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechaprometidaproduccion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechaconfirmacionpedido { get; set; }

    [StringLength(100)]
    public string? idtransportadornacional { get; set; }

    public string? placa { get; set; }

    public string? nombreconductor { get; set; }

    public string? cedulaconductor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? numeroguia { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechadoc { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? modalidadfletes { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string cargasuelta { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? m3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? mediotransporte { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? aerolinea { get; set; }

    [StringLength(200)]
    public string? agenterepresentante { get; set; }

    [StringLength(301)]
    [Unicode(false)]
    public string? viaje { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechallegada { get; set; }

    [StringLength(50)]
    public string? paisdestino { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? lugardestino { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? destinofinal { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? clienteimportador { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? direcciondestinatario { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? contactodestinatario { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechaentrega { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? lugarcargue { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechaprogramadacargue { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nropedido { get; set; }

    public string? factura { get; set; }

    public string? fechafactura { get; set; }

    [StringLength(100)]
    public string? terminonegociacion { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? total { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? flete { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? totaltermino { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sistemasespeciales { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? certificadoorigen { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechazarpe { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? agenciaaduanas { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? dexdefinitivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadexdefinitivo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? tracker { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechaguia { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    public int? tiempociclo { get; set; }

    [StringLength(97)]
    [Unicode(false)]
    public string? calificacion { get; set; }

    [StringLength(121)]
    [Unicode(false)]
    public string? calidad { get; set; }

    [StringLength(127)]
    [Unicode(false)]
    public string? documentacion { get; set; }

    [StringLength(122)]
    [Unicode(false)]
    public string? servicio { get; set; }

    [StringLength(122)]
    [Unicode(false)]
    public string? analisis { get; set; }

    [StringLength(4088)]
    [Unicode(false)]
    public string? causales { get; set; }
}
