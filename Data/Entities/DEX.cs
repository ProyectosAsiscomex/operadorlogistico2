using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DEX")]
public partial class DEX
{
    [Key]
    public int IdDEX { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDEX { get; set; }

    [StringLength(20)]
    public string? NumeroDEX { get; set; }

    [StringLength(50)]
    public string? NumeroAutorizacionEmbarque { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaAutorizacion { get; set; }

    public int? IdAutorizacionEmbarque { get; set; }

    public int? IdExportador { get; set; }

    public int? IdDeclarante { get; set; }

    [StringLength(10)]
    public string? IdentPersonaDeclarante { get; set; }

    [StringLength(200)]
    public string? NombrePersonaDeclarante { get; set; }

    public int? IdImportador { get; set; }

    [StringLength(200)]
    public string? DireccionDestino { get; set; }

    public int? IdPais { get; set; }

    [StringLength(100)]
    public string? CiudadDestino { get; set; }

    [StringLength(15)]
    public string? TipoDeclaracion { get; set; }

    [StringLength(1)]
    public string? CodigoTipoDeclaracion { get; set; }

    [StringLength(3)]
    public string? CodigoLugarSalida { get; set; }

    [StringLength(3)]
    public string? CodigoRegionProcedencia { get; set; }

    [StringLength(20)]
    public string? DeclaracionAnt { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDeclaracionAnt { get; set; }

    [StringLength(20)]
    public string? AdhesivoDIMAnt { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDIMAnt { get; set; }

    [StringLength(4)]
    public string? CodigoModalidadImpo { get; set; }

    [StringLength(2)]
    public string? CodigoOficinaMincomercio { get; set; }

    [StringLength(3)]
    public string? CodigoMoneda { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorTotalMonedaNeg { get; set; }

    public int? IdModoTransporte { get; set; }

    [StringLength(200)]
    public string? CodigoBandera { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? PesoBruto { get; set; }

    [StringLength(4)]
    public string? CodigoRegimenAduanero { get; set; }

    [StringLength(4)]
    public string? CodigoModalidad { get; set; }

    [StringLength(1)]
    public string? CodigoFormaPago { get; set; }

    public int? CantidadPagosAnticipados { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaPrimerPagoAnt { get; set; }

    [StringLength(1)]
    public string? CodigoEmbarque { get; set; }

    [StringLength(1)]
    public string? Consolidacion { get; set; }

    public int? CantidadEmbarques { get; set; }

    [StringLength(1)]
    public string? CodigoTipoDatos { get; set; }

    [StringLength(2)]
    public string? CodigoEmbalaje { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? CantidadEmbalajes { get; set; }

    [StringLength(400)]
    public string? MarcasNumeros { get; set; }

    [StringLength(1)]
    public string? CertificadoOrigen { get; set; }

    [StringLength(50)]
    public string? CualCertificado { get; set; }

    public bool? SistemasEspeciales { get; set; }

    [StringLength(6)]
    public string? NPrograma1 { get; set; }

    [StringLength(6)]
    public string? NPrograma2 { get; set; }

    [StringLength(6)]
    public string? NPrograma3 { get; set; }

    [StringLength(6)]
    public string? NPrograma4 { get; set; }

    [StringLength(6)]
    public string? NPrograma5 { get; set; }

    [StringLength(6)]
    public string? NPrograma6 { get; set; }

    public bool? Reposicion { get; set; }

    [StringLength(1000)]
    public string? VistoBuenoEntidad1 { get; set; }

    [StringLength(100)]
    public string? NumeroVistoBuenoEntidad1 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVistoBuenoEntidad1 { get; set; }

    [StringLength(1000)]
    public string? VistoBuenoEntidad2 { get; set; }

    [StringLength(100)]
    public string? NumeroVistoBuenoEntidad2 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVistoBuenoEntidad2 { get; set; }

    [StringLength(1)]
    public string? CodigoExportacionTransito { get; set; }

    [StringLength(3)]
    public string? CodigoAdmonEmbarque { get; set; }

    [StringLength(1)]
    public string? CodigoLocalizacionMcia { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorFletes { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorSeguros { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorOtrosGastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorReintegrar { get; set; }

    public bool? ProcedeEmbarque { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaProcedeEmbarque { get; set; }

    [StringLength(40)]
    public string? AutoyActaEmbarque { get; set; }

    [StringLength(40)]
    public string? NumeroManifiestoCarga { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaManifiesto { get; set; }

    [StringLength(3)]
    public string? CodidoAdmonManifiesto { get; set; }

    public int? NumeroBultosManifiesto { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? PesoNetoManifiesto { get; set; }

    [StringLength(300)]
    public string? IdentificacionMedioTransporte { get; set; }

    public string? ObservacionesManifiesto { get; set; }

    [StringLength(20)]
    public string? NumeroDecaracionDefinitiva { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDeclaracionDefinitiva { get; set; }

    public string? NumerosHojasAnexas { get; set; }

    [StringLength(2)]
    public string? CodigoAdministracion { get; set; }

    [StringLength(2)]
    public string? CodigoDepartamento { get; set; }

    [StringLength(3)]
    public string? CodigoMunicipio { get; set; }
}
