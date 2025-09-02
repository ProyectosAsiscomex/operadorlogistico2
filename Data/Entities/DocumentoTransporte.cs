using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DocumentoTransporte")]
public partial class DocumentoTransporte
{
    [Key]
    public int idBL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tipo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nodocumento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? noreserva { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? orientregaren { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaembarque { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? mediotransporte { get; set; }

    public int? idembarcador { get; set; }

    public int? idpaisorigen { get; set; }

    public int? idpuertoorigen { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? muelleorigen { get; set; }

    public int? idaeropuertoorigen { get; set; }

    public int? idconsignatario { get; set; }

    public int? idpaisdestino { get; set; }

    public int? idpuertodestino { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? muelledestino { get; set; }

    public int? idaeropuertodestino { get; set; }

    public int? idexportador { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? idsianotificara { get; set; }

    public int? idsiaagente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idtransportador { get; set; }

    public int? idmoneda { get; set; }

    public int? idincoterm { get; set; }

    public int? idpais { get; set; }

    public int? idtipocarga { get; set; }

    public int? idunidadcarga { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? indicadorbultos { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? cantidadindicadorbultos { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesonetoindicadorbultos { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? pesobrutoindicadorbultos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? peligrosidadcarga { get; set; }

    public int? iddispocisioncarga { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? dimensiones { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? volumen { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fletes { get; set; }

    [Column(TypeName = "money")]
    public decimal? fletebase { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalfleteusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "money")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? ajustes { get; set; }

    public int? cmbidpais { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? granelesrepeso { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nomanifiesto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechamanifiesto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechamotonave { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaubicacionbl { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacertificado { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? deposito { get; set; }

    public int? idaduana { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharecibooriginal { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? buque { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? numerobultos { get; set; }

    public int? iddo { get; set; }

    public int? idnaviera { get; set; }

    public bool? nacionalizado { get; set; }

    [Column(TypeName = "money")]
    public decimal? Valordia { get; set; }

    public byte? diasLibres { get; set; }

    [Unicode(false)]
    public string? observaciones { get; set; }

    [Unicode(false)]
    public string? idaeropuertoorigen2 { get; set; }

    [Unicode(false)]
    public string? idaeropuertodestino2 { get; set; }

    public int? IDLISTACHEQUEO { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? porseguro { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastosexwfca { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? aeropuertoorigen { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? aeropuertodestino { get; set; }

    public int? idmonedaseguro { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? gastosconexos { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? bProrrateaEXWFCA { get; set; }

    public bool? conexosusd { get; set; }

    public bool? gastosexwfcausd { get; set; }

    public bool? ajustesusd { get; set; }

    public bool? otrosgastosusd { get; set; }

    public bool? fletesusd { get; set; }

    public int? idlugaringresomercancias { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechallegada { get; set; }

    [StringLength(300)]
    public string? bodegazf { get; set; }

    public int? idtransportadornacional { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? observacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? hijo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroPoliza { get; set; }

    [StringLength(250)]
    public string? nameMBL { get; set; }

    [StringLength(100)]
    public string? AddressMBL { get; set; }

    [StringLength(20)]
    public string? PhoneMBL { get; set; }

    [StringLength(100)]
    public string? cityMBL { get; set; }

    [StringLength(100)]
    public string? CountryMBL { get; set; }

    [StringLength(250)]
    public string? nameHBL { get; set; }

    [StringLength(100)]
    public string? AddressHBL { get; set; }

    [StringLength(20)]
    public string? PhoneHBL { get; set; }

    [StringLength(100)]
    public string? cityHBL { get; set; }

    [StringLength(100)]
    public string? CountryHBL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nieto { get; set; }
}
