using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tbDeclaracionExportacion")]
public partial class tbDeclaracionExportacion
{
    /// <summary>
    /// consecutivo de la declaracion
    /// </summary>
    [Key]
    public long nIdConsecutivo { get; set; }

    /// <summary>
    /// consecutivo del do
    /// </summary>
    public long? nConsDo { get; set; }

    /// <summary>
    /// Código del documento según tabla tbDocumento
    /// </summary>
    public short? nDocumento { get; set; }

    /// <summary>
    /// Si tiene 1 es el ultimo archivo subido para la operación o DO 
    /// </summary>
    public bool? nUltimo { get; set; }

    /// <summary>
    /// Año del aoperación
    /// </summary>
    [StringLength(4)]
    public string cAnno { get; set; } = null!;

    /// <summary>
    /// Número de formulario 
    /// </summary>
    [StringLength(20)]
    public string cNumeroFormulario { get; set; } = null!;

    /// <summary>
    /// Nit del exportador
    /// </summary>
    [StringLength(11)]
    public string? cNitExportador { get; set; }

    /// <summary>
    /// Digito de chequeo del exportador
    /// </summary>
    [StringLength(1)]
    public string? cDVExportador { get; set; }

    /// <summary>
    /// Apellidos y nombres o Razon Social del exportador
    /// </summary>
    [StringLength(100)]
    public string? cRazonSocialExportador { get; set; }

    /// <summary>
    /// Dirección del exportador
    /// </summary>
    [StringLength(100)]
    public string? cDireccionExportador { get; set; }

    /// <summary>
    /// Teléfono del exportador
    /// </summary>
    [StringLength(10)]
    public string? cTelefonoExportador { get; set; }

    /// <summary>
    /// Código Admon
    /// </summary>
    [StringLength(2)]
    public string? cCodAdmonExportador { get; set; }

    /// <summary>
    /// Cod. Dpto 
    /// </summary>
    [StringLength(2)]
    public string? cCodDptoExportador { get; set; }

    /// <summary>
    /// Cod. Municipio 
    /// </summary>
    [StringLength(3)]
    public string? cCodMunicipioExportador { get; set; }

    /// <summary>
    /// Nit de Mario Londoño 
    /// </summary>
    [StringLength(11)]
    public string? cNitDeclarante { get; set; }

    /// <summary>
    /// Digito verificación del Nit de Mario Londoño
    /// </summary>
    [StringLength(1)]
    public string? cDVDeclarante { get; set; }

    /// <summary>
    /// Apellidos y nombres o Razon Social del declarante autorizado
    /// </summary>
    [StringLength(100)]
    public string? cRazonSocilaDeclarante { get; set; }

    /// <summary>
    /// Tipo de Usuario
    /// </summary>
    [StringLength(2)]
    public string? cTipoUsuarioDeclarante { get; set; }

    /// <summary>
    /// Código declarante
    /// </summary>
    [StringLength(5)]
    public string? cCodigoDeclarante { get; set; }

    /// <summary>
    /// Documento de identificación empleado Mario Londoño
    /// </summary>
    [StringLength(11)]
    public string? cDocumentoDeclarante { get; set; }

    /// <summary>
    /// Apellidos y nombres de quien suscribe el documento
    /// </summary>
    [StringLength(100)]
    public string? CNombreDeclarante { get; set; }

    /// <summary>
    /// Clase de exportador
    /// </summary>
    [StringLength(2)]
    public string? cClaseExportador { get; set; }

    /// <summary>
    /// Nombre o razón social importador o consignatario
    /// </summary>
    [StringLength(100)]
    public string? cRazonSocialImportador { get; set; }

    /// <summary>
    /// Dirección pais de destino
    /// </summary>
    [StringLength(100)]
    public string? cDireccionDestino { get; set; }

    /// <summary>
    /// Cod. Pais Destino
    /// </summary>
    [StringLength(3)]
    public string? cCodPaisDestino { get; set; }

    /// <summary>
    /// Ciudad del pais de destino
    /// </summary>
    [StringLength(50)]
    public string? cCiudadPaisDestino { get; set; }

    /// <summary>
    /// Autorización de embarque
    /// </summary>
    [StringLength(16)]
    public string? cAutorizacionEmbarque { get; set; }

    /// <summary>
    /// Fecha de embarque
    /// </summary>
    [StringLength(20)]
    public string? cFechaEmbarque { get; set; }

    /// <summary>
    /// Tipo declaración
    /// </summary>
    [StringLength(20)]
    public string? cTipoDeclaracion { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(2)]
    public string? cCod { get; set; }

    /// <summary>
    /// Código lugar de salida
    /// </summary>
    [StringLength(5)]
    public string? cCodLugarSalida { get; set; }

    /// <summary>
    /// Cod. dpto. procedencia
    /// </summary>
    [StringLength(2)]
    public string? cCodDptoProcedencia { get; set; }

    /// <summary>
    /// Declaración exportación anterior
    /// </summary>
    [StringLength(20)]
    public string? cDeclaracionExportacionAnterior { get; set; }

    /// <summary>
    /// Fecha exportación anterior
    /// </summary>
    [StringLength(20)]
    public string? cFechaExportacionAnterior { get; set; }

    /// <summary>
    /// Autohadesivo Declaración de Importación anterior
    /// </summary>
    [StringLength(20)]
    public string? cAutohadesivoImportacionAnterior { get; set; }

    /// <summary>
    /// Fecha Autohadesivo Declaración de Importación anterior
    /// </summary>
    [StringLength(20)]
    public string? cFechaAutohadesivoImportacionAnterior { get; set; }

    /// <summary>
    /// Cod. Modalidad Importación
    /// </summary>
    [StringLength(5)]
    public string? cCodModalidadImportacion { get; set; }

    /// <summary>
    /// Cod Ofic. Regional Mincomercio Industria y Turismo 
    /// </summary>
    [StringLength(2)]
    public string? cCodOficIndustriaTurismo { get; set; }

    /// <summary>
    /// Código moneda de negociación 
    /// </summary>
    [StringLength(5)]
    public string? cCodigoMonedaNegociacion { get; set; }

    /// <summary>
    /// Valor total en moneda de negociación
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nValorTotalMonedaNegociacion { get; set; }

    /// <summary>
    /// Código modo de transporte
    /// </summary>
    [StringLength(2)]
    public string? cCodigoModoTransporte { get; set; }

    /// <summary>
    /// Código bandera
    /// </summary>
    [StringLength(5)]
    public string? cCodigoBandera { get; set; }

    /// <summary>
    /// Peso bruto kgs
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nPesoBrutoKgs { get; set; }

    /// <summary>
    /// Código modalidad
    /// </summary>
    [StringLength(5)]
    public string? cCodigoModalidad { get; set; }

    /// <summary>
    /// Código forma de pago
    /// </summary>
    [StringLength(2)]
    public string? cCodFormaPago { get; set; }

    /// <summary>
    /// Cantidad de pagos anticipados
    /// </summary>
    public short? nCantidadPagosAnticipados { get; set; }

    /// <summary>
    /// Fecha primer pago anticipado
    /// </summary>
    [StringLength(20)]
    public string? cFechaPrimerPagoAnticipado { get; set; }

    /// <summary>
    /// Código embarque
    /// </summary>
    [StringLength(2)]
    public string? cCodEmbarque { get; set; }

    /// <summary>
    /// Consolidación
    /// </summary>
    [StringLength(2)]
    public string? cConsolidacion { get; set; }

    /// <summary>
    /// Cantidad de Embarques
    /// </summary>
    public short? nCantidadEmbarques { get; set; }

    /// <summary>
    /// Código datos
    /// </summary>
    [StringLength(2)]
    public string? cCodDatos { get; set; }

    /// <summary>
    /// Códigos Embalajes
    /// </summary>
    [StringLength(50)]
    public string? cEmbalajes { get; set; }

    /// <summary>
    /// Cantidad
    /// </summary>
    [StringLength(50)]
    public string? nCantidad { get; set; }

    /// <summary>
    /// Marcas y números
    /// </summary>
    [StringLength(100)]
    public string? cMarcarsYNumeros { get; set; }

    /// <summary>
    /// Certificado de origen
    /// </summary>
    [StringLength(5)]
    public string? cCertificadoOrigen { get; set; }

    [StringLength(100)]
    public string? cCertificadoOrigenCual { get; set; }

    /// <summary>
    /// Sistemas especiales
    /// </summary>
    [StringLength(100)]
    public string? cSistemasEspeciales { get; set; }

    [StringLength(50)]
    public string? cNroPrograma01 { get; set; }

    [StringLength(20)]
    public string? cNroPrograma02 { get; set; }

    [StringLength(20)]
    public string? cNroPrograma03 { get; set; }

    [StringLength(20)]
    public string? cNroPrograma04 { get; set; }

    [StringLength(20)]
    public string? cNroPrograma05 { get; set; }

    [StringLength(20)]
    public string? cNroPrograma06 { get; set; }

    [StringLength(1)]
    public string? cReposicion { get; set; }

    /// <summary>
    /// Visto bueno entidad
    /// </summary>
    [StringLength(100)]
    public string? cVistoBuenoEntidad01 { get; set; }

    [StringLength(100)]
    public string? cVistoBuenoEntidadNro01 { get; set; }

    [StringLength(10)]
    public string? cVistoBuenoEntidadFecha01 { get; set; }

    /// <summary>
    /// Visto bueno entidad
    /// </summary>
    [StringLength(100)]
    public string? cVistoBuenoEntidad02 { get; set; }

    [StringLength(100)]
    public string? cVistoBuenoEntidadNro02 { get; set; }

    [StringLength(10)]
    public string? cVistoBuenoEntidadFecha02 { get; set; }

    /// <summary>
    /// Código exportación en tránsito
    /// </summary>
    [StringLength(5)]
    public string? cCodigoExportacionTransito { get; set; }

    /// <summary>
    /// Código Admon. de Embarque
    /// </summary>
    [StringLength(5)]
    public string? cCodigoAdmonEmbarque { get; set; }

    /// <summary>
    /// Código localización mercancía
    /// </summary>
    [StringLength(5)]
    public string? cCodigoLocalizacionMercancia { get; set; }

    [StringLength(100)]
    public string? cHojasAnexasNumeros { get; set; }

    /// <summary>
    /// Total Peso neto Kgs
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nTotalPesoNetoKgs { get; set; }

    /// <summary>
    /// Total Valor FOB 
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nTotalValorFOB { get; set; }

    /// <summary>
    /// Total Valor Agregado Nal. USD
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nTotalValorAgregadoNal { get; set; }

    public short? nCantidadHojaAnexas { get; set; }

    /// <summary>
    /// Valor fletes USD
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nValorFletes { get; set; }

    /// <summary>
    /// Valor seguros USD
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nValorSeguros { get; set; }

    /// <summary>
    ///  Valor otros gastos USD
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nValorOtrosGastos { get; set; }

    /// <summary>
    /// Valor total de la exportación USD
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nValorTotalExportacion { get; set; }

    /// <summary>
    /// Valor a reintegrar USD
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? nValorAReintegrar { get; set; }

    /// <summary>
    /// Procede el Embaque? Embarque Directo 
    /// </summary>
    [StringLength(100)]
    public string? cProcedeEmbarque { get; set; }

    /// <summary>
    /// Fecha Procede el Embaque? Embarque Directo 
    /// </summary>
    [StringLength(20)]
    public string? cFechaProcedeEmbarque { get; set; }

    /// <summary>
    /// Auto y Acta 
    /// </summary>
    [StringLength(20)]
    public string? cAutoActa { get; set; }

    /// <summary>
    /// Número Manifiesto de Carga
    /// </summary>
    [StringLength(50)]
    public string? cNroManifiestoCarga { get; set; }

    /// <summary>
    /// Fecha Manifiesto de Carga
    /// </summary>
    [StringLength(50)]
    public string? cFechaManifiestoCarga { get; set; }

    /// <summary>
    /// Código Administración Certificación
    /// </summary>
    [StringLength(10)]
    public string? cCodAdmonCertificacion { get; set; }

    /// <summary>
    /// No. Bultos 
    /// </summary>
    [StringLength(50)]
    public string? nNroBultos { get; set; }

    /// <summary>
    /// Peso(Kgr)
    /// </summary>
    [StringLength(50)]
    public string? nPesoKgr { get; set; }

    /// <summary>
    /// Identificacion del medio de transporte
    /// </summary>
    [StringLength(100)]
    public string? cIdentificacionMedioTransporte { get; set; }

    /// <summary>
    /// Observaciones
    /// </summary>
    [StringLength(100)]
    public string? cObservaciones { get; set; }

    /// <summary>
    /// Número Declaración de exportación definitiva
    /// </summary>
    [StringLength(15)]
    public string? cDeclaracionExportacionDefinitiva { get; set; }

    /// <summary>
    /// Fecha Declaración de exportación definitiva
    /// </summary>
    [StringLength(10)]
    public string? cFechaExportacionDefinitiva { get; set; }

    /// <summary>
    /// Nombre del que firma
    /// </summary>
    [StringLength(50)]
    public string? cNombre { get; set; }

    /// <summary>
    /// Identificación del que firma
    /// </summary>
    [StringLength(11)]
    public string? cIdentificacionFirma { get; set; }

    /// <summary>
    /// Nombre inspector
    /// </summary>
    [StringLength(30)]
    public string? cNombreInspector { get; set; }

    /// <summary>
    /// Identificacón inspector
    /// </summary>
    [StringLength(11)]
    public string? cIdentificacionInspector { get; set; }

    [StringLength(1000)]
    public string? cJustificaciónDeLaCorreccion { get; set; }

    /// <summary>
    /// Nombre del archivo fuente
    /// </summary>
    [StringLength(99)]
    public string? cNombreArchivoFuente { get; set; }
}
