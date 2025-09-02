using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Tercero
{
    [Key]
    public int idTercero { get; set; }

    [StringLength(20)]
    public string? cNit { get; set; }

    [StringLength(100)]
    public string? cNombre { get; set; }

    [StringLength(30)]
    public string? cTelefono { get; set; }

    [StringLength(250)]
    public string? cDireccion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ReferenciadoPor { get; set; }

    public bool? Habilitado { get; set; }

    public int? TipoDocumento { get; set; }

    public int? DV { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CodContable { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PrimerApellido { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SegundoApellido { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PrimerNombre { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? OtrosNombres { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? NombreComercial { get; set; }

    public int? Pais { get; set; }

    public int? Departamento { get; set; }

    public int? Ciudad { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ZonaSector { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Celular { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Fax { get; set; }

    public int? ActvidadEconomica { get; set; }

    public int? Solicito { get; set; }

    public int? Aprobo { get; set; }

    public int? Modifico { get; set; }

    public bool? GranContribuyente { get; set; }

    public bool? Autoretenedor { get; set; }

    public bool? RegimenComun { get; set; }

    public bool? EsProveedorCI { get; set; }

    public bool? AplicaGravamenfinanciero { get; set; }

    public bool? Excentoretencion { get; set; }

    public bool? FacturaIVA { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porRetefuente { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Base { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porReteivaEspecial { get; set; }

    public int? DiasVencimiento { get; set; }

    public int? iddepartamento { get; set; }

    public int? idciudad { get; set; }

    public int? actividadEconomica { get; set; }

    public bool? importaciones { get; set; }

    public bool? exportaciones { get; set; }

    public bool? transitosaduanero { get; set; }

    public bool? anticipoParagastos { get; set; }

    public bool? anticipoparaimpuestos { get; set; }

    public int? formaPagoimpuestos { get; set; }

    [Unicode(false)]
    public string? observacionesdelanegociacion { get; set; }

    public int? ciudadgenerodo { get; set; }

    public bool? exigirfactura { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AsesorVendedor { get; set; }

    public bool? bloqueado { get; set; }

    public bool? RegistrarClienteA { get; set; }

    public bool? RegistrarClienteNA { get; set; }

    [Unicode(false)]
    public string? RegistrarClienteNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegistrarClienteFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegistrarClienteValidoHasta { get; set; }

    public bool? CamaraComercioA { get; set; }

    public bool? CamaraComercioNA { get; set; }

    [Unicode(false)]
    public string? CamaraComercioNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CamaraComercioFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CamaraComercioValidoHasta { get; set; }

    public bool? RutA { get; set; }

    public bool? RutNA { get; set; }

    [Unicode(false)]
    public string? RutNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RutFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RutValidoHasta { get; set; }

    public bool? CCRepresentanteLegalA { get; set; }

    public bool? CCRepresentanteLegalNA { get; set; }

    [Unicode(false)]
    public string? CCRepresentanteLegalNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CCRepresentanteLegalFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CCRepresentanteLegalValidoHasta { get; set; }

    public bool? EstadosFinancierosDRentaA { get; set; }

    public bool? EstadosFinancierosDRentaNA { get; set; }

    [Unicode(false)]
    public string? EstadosFinancierosDRentaNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EstadosFinancierosDRentaFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EstadosFinancierosDRentaValidoHasta { get; set; }

    public bool? EstudioFinancierosSClienteA { get; set; }

    public bool? EstudioFinancierosSClienteNA { get; set; }

    [Unicode(false)]
    public string? EstudioFinancierosSClienteNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EstudioFinancierosSClienteFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EstudioFinancierosSClienteValidoHasta { get; set; }

    public bool? ReferenciaComercialA { get; set; }

    public bool? ReferenciaComercialNA { get; set; }

    [Unicode(false)]
    public string? ReferenciaComercialNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ReferenciaComercialFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ReferenciaComercialValidoHasta { get; set; }

    public bool? ReferenciaBancariaA { get; set; }

    public bool? ReferenciaBancariaNA { get; set; }

    [Unicode(false)]
    public string? ReferenciaBancariaNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ReferenciaBancariaFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ReferenciaBancariaValidoHasta { get; set; }

    public bool? AcuerdoSeguridadA { get; set; }

    public bool? AcuerdoSeguridadNA { get; set; }

    [Unicode(false)]
    public string? AcuerdoSeguridadNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? AcuerdoSeguridadFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? AcuerdoSeguridadValidoHasta { get; set; }

    public bool? VisitaSeguridadA { get; set; }

    public bool? VisitaSeguridadNA { get; set; }

    [Unicode(false)]
    public string? VisitaSeguridadNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VisitaSeguridadFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VisitaSeguridadValidoHasta { get; set; }

    public bool? CertificadoBASCA { get; set; }

    public bool? CertificadoBASCNA { get; set; }

    [Unicode(false)]
    public string? CertificadoBASCNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CertificadoBASCFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CertificadoBASCValidoHasta { get; set; }

    public bool? OtrasCertificacionesA { get; set; }

    public bool? OtrasCertificacionesNA { get; set; }

    [Unicode(false)]
    public string? OtrasCertificacionesNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OtrasCertificacionesFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OtrasCertificacionesValidoHasta { get; set; }

    public bool? Circular0170A { get; set; }

    public bool? Circular0170NA { get; set; }

    [Unicode(false)]
    public string? Circular0170NroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Circular0170FechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Circular0170ValidoHasta { get; set; }

    public bool? VerificacionAntecedentesOFACPONALA { get; set; }

    public bool? VerificacionAntecedentesOFACPONALNA { get; set; }

    [Unicode(false)]
    public string? VerificacionAntecedentesOFACPONALNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VerificacionAntecedentesOFACPONALFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VerificacionAntecedentesOFACPONALValidoHasta { get; set; }

    public bool? GarantiaContenedoresA { get; set; }

    public bool? GarantiaContenedoresNA { get; set; }

    [Unicode(false)]
    public string? GarantiaContenedoresNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? GarantiaContenedoresFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? GarantiaContenedoresValidoHasta { get; set; }

    [StringLength(40)]
    public string? Criticidad { get; set; }

    [StringLength(40)]
    public string? Cumplimiento { get; set; }

    public int? idTipoAsociadoNegocio { get; set; }

    public bool? PolizaTransportadoraA { get; set; }

    public bool? PolizaTransportadoraNA { get; set; }

    [Unicode(false)]
    public string? PolizaTransportadoraNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PolizaTransportadoraFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PolizaTransportadoraValidoHasta { get; set; }

    public bool? AcuerdoConfidencialidadA { get; set; }

    public bool? AcuerdoConfidencialidadNA { get; set; }

    [Unicode(false)]
    public string? AcuerdoConfidencialidadNroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? AcuerdoConfidencialidadFechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? AcuerdoConfidencialidadValidoHasta { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCreacion { get; set; }

    public bool? oGremioA { get; set; }

    public bool? oGremioNA { get; set; }

    [StringLength(100)]
    public string? oGremioNumero { get; set; }

    [StringLength(100)]
    public string? ofechadocumentoGremio { get; set; }

    [StringLength(100)]
    public string? ValidoGremio { get; set; }

    public bool? oSopA { get; set; }

    public bool? oSopNA { get; set; }

    [StringLength(100)]
    public string? oSopNumero { get; set; }

    [StringLength(100)]
    public string? ofechadocumentoSop { get; set; }

    [StringLength(100)]
    public string? ValidoSop { get; set; }

    public string? ObservacionesGenerales { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cuentacontabilidad { get; set; }

    public bool naviera { get; set; }

    [InverseProperty("idTerceroNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; } = new List<ReciboCajaAnticipo>();

    [InverseProperty("idTerceroNavigation")]
    public virtual ICollection<ReciboCajaMenor> ReciboCajaMenors { get; set; } = new List<ReciboCajaMenor>();
}
