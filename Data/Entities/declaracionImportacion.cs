using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("declaracionImportacion")]
public partial class declaracionImportacion
{
    [Key]
    public int iddeclaimpo { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? añodecla { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroformulario { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nroauxiliar { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaauxiliar { get; set; }

    public int? idexportador { get; set; }

    public int? iddeclarante { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? claseimportador { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? tipodecla { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroformularioant { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaformularioant { get; set; }

    public int? idaduana { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? nrodeclaracionexpo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadeclaracionexpo { get; set; }

    public int? idaduanaexpo { get; set; }

    public int? idlugaringmercancia { get; set; }

    public int? iddepositohabilitado { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? manifestocarga { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechamanifestocarga { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? doctransporte { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadoctransporte { get; set; }

    public int? idprovedor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechanrofactura { get; set; }

    public int? idpaises { get; set; }

    public int? idmodotransporte { get; set; }

    public int? idcodbandera { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? iddepardestino { get; set; }

    public int? empresatransportadora { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? idmonedas { get; set; }

    public int? idarancel { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? codcomplementario { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? codsuplementario { get; set; }

    public int? idmodalidad { get; set; }

    public int? nrocuotas { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? vlcuotausd { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? periodicidadpagocuota { get; set; }

    public int? idpaises2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? codacuerdo { get; set; }

    public int? formapago { get; set; }

    public int? tipoimportacion { get; set; }

    public int? idpaises3compra { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobrutokgs { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesonetokgs { get; set; }

    public int? codembalaje { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? nrobultos { get; set; }

    public int? subpartidas { get; set; }

    public int? idunidadcomercial { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfletesusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorsegurosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorotrosgastosusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? sumatoriausd { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ajustevlusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? vladuanausd { get; set; }

    public int? codregistro { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? numero { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? codoficina { get; set; }

    public int? año { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? nroprograma { get; set; }

    [StringLength(10)]
    public string? codproducto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porarancel { get; set; }

    [Column(TypeName = "money")]
    public decimal? basearancel { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadoarancel { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagardeclaracionarancel { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadosusdarancel { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? poriva { get; set; }

    [Column(TypeName = "money")]
    public decimal? baseiva { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadoiva { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagardeclaracioniva { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadousdiva { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porsalvaguardia { get; set; }

    [Column(TypeName = "money")]
    public decimal? basesalvaguardia { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadosalvaguardia { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagardeclaracionsalvaguardia { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadousdsalvaguardia { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porderechoscompen { get; set; }

    [Column(TypeName = "money")]
    public decimal? basederechoscompen { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadoderechoscompen { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagardecladerechoscompen { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadousdderechoscompen { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pordereantidumping { get; set; }

    [Column(TypeName = "money")]
    public decimal? baseantidumping { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadoantidumping { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagardeclaracionantidumping { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadousdantidumping { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porsancion { get; set; }

    [Column(TypeName = "money")]
    public decimal? basesancion { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadosancion { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagardeclaracionsancion { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porrescate { get; set; }

    [Column(TypeName = "money")]
    public decimal? baserescate { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlliquidadorescate { get; set; }

    [Column(TypeName = "money")]
    public decimal? tlpagarrescate { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalliquidadopesos { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalliquidadousd { get; set; }

    [Column(TypeName = "money")]
    public decimal? vlpagosanteriores { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrorecibopagoanterior { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharecibopagoanterior { get; set; }

    [StringLength(100)]
    public string? nroaceptacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaaceptacion { get; set; }

    [StringLength(100)]
    public string? nrolevante { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechalevante { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nombreempleado { get; set; }

    public int? cedulaempleado { get; set; }

    [Column(TypeName = "money")]
    public decimal? pagototal { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? corigen { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nrosticker { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? fechasticker { get; set; }

    public int? idaduana2 { get; set; }

    [StringLength(30)]
    public string? nrocertificado { get; set; }

    [StringLength(30)]
    public string? nrodeclacambio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadeclacambio { get; set; }

    [StringLength(400)]
    public string? signatario { get; set; }

    [StringLength(100)]
    public string? cedulasignatario { get; set; }

    public int? iddeclaandina { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idtipo { get; set; }

    public bool? mixtopares { get; set; }

    public bool? mixtopeso { get; set; }

    public int? idusuario { get; set; }

    public bool? electronico { get; set; }

    public bool? excluiruap { get; set; }

    [InverseProperty("idDeclaracionNavigation")]
    public virtual ICollection<RadicadosEdiFac> RadicadosEdiFacs { get; set; } = new List<RadicadosEdiFac>();

    [InverseProperty("idDeclaracionNavigation")]
    public virtual ICollection<SoporteDim> SoporteDims { get; set; } = new List<SoporteDim>();
}
