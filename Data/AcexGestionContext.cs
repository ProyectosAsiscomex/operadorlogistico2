using System;
using System.Collections.Generic;
using AsiscomexOperadorLogistico.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data;

public partial class AcexGestionContext : DbContext
{
    public AcexGestionContext(DbContextOptions<AcexGestionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AMX> AMXes { get; set; }

    public virtual DbSet<Activacionalerta> Activacionalertas { get; set; }

    public virtual DbSet<Actividade> Actividades { get; set; }

    public virtual DbSet<ActividadesDetalle> ActividadesDetalles { get; set; }

    public virtual DbSet<ActividadesListaChequeo> ActividadesListaChequeos { get; set; }

    public virtual DbSet<AcuerdosComerciale> AcuerdosComerciales { get; set; }

    public virtual DbSet<AcuerdosInternacionale> AcuerdosInternacionales { get; set; }

    public virtual DbSet<AcuerdosxPai> AcuerdosxPais { get; set; }

    public virtual DbSet<Adjunto> Adjuntos { get; set; }

    public virtual DbSet<AdjuntosEstado> AdjuntosEstados { get; set; }

    public virtual DbSet<AdjuntosEstadoFlete> AdjuntosEstadoFletes { get; set; }

    public virtual DbSet<AdjuntosExpo> AdjuntosExpos { get; set; }

    public virtual DbSet<AdjuntosPlanvallejo> AdjuntosPlanvallejos { get; set; }

    public virtual DbSet<Aeropuerto> Aeropuertos { get; set; }

    public virtual DbSet<AgendarCitum> AgendarCita { get; set; }

    public virtual DbSet<Alerta> Alertas { get; set; }

    public virtual DbSet<AlertaComentario> AlertaComentarios { get; set; }

    public virtual DbSet<AlertasAdjunto> AlertasAdjuntos { get; set; }

    public virtual DbSet<AlertasCorreosConfiguracion> AlertasCorreosConfiguracions { get; set; }

    public virtual DbSet<AlertasGenerada> AlertasGeneradas { get; set; }

    public virtual DbSet<AlertasRecurrente> AlertasRecurrentes { get; set; }

    public virtual DbSet<AlertasRecurrentesDisparador> AlertasRecurrentesDisparadors { get; set; }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<AmxConcepto> AmxConceptos { get; set; }

    public virtual DbSet<AndinaxDeclaracion> AndinaxDeclaracions { get; set; }

    public virtual DbSet<Anticipo> Anticipos { get; set; }

    public virtual DbSet<AnticiposPendiente> AnticiposPendientes { get; set; }

    public virtual DbSet<Arancel> Arancels { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreasLogistica> AreasLogisticas { get; set; }

    public virtual DbSet<Arquear> Arquears { get; set; }

    public virtual DbSet<ArqueoCaja> ArqueoCajas { get; set; }

    public virtual DbSet<Aseguradora> Aseguradoras { get; set; }

    public virtual DbSet<AsignacionTransporte_Madecentro> AsignacionTransporte_Madecentros { get; set; }

    public virtual DbSet<AsuntosCorreoEnviadoPorDO> AsuntosCorreoEnviadoPorDOs { get; set; }

    public virtual DbSet<AumentoMonto> AumentoMontos { get; set; }

    public virtual DbSet<AutorizacionEmbarqueReport> AutorizacionEmbarqueReports { get; set; }

    public virtual DbSet<Autorizacione> Autorizaciones { get; set; }

    public virtual DbSet<Autorizaciones_Impuesto> Autorizaciones_Impuestos { get; set; }

    public virtual DbSet<Autorizaciones_Tercero> Autorizaciones_Terceros { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BibliotecaExportacion> BibliotecaExportacions { get; set; }

    public virtual DbSet<BorrarTempoAran> BorrarTempoArans { get; set; }

    public virtual DbSet<CORREOSTEMPO> CORREOSTEMPOs { get; set; }

    public virtual DbSet<CajaMenor> CajaMenors { get; set; }

    public virtual DbSet<CalificacionProveedore> CalificacionProveedores { get; set; }

    public virtual DbSet<CalificacionProveedoresDetalle> CalificacionProveedoresDetalles { get; set; }

    public virtual DbSet<CambiosEnCatalogo> CambiosEnCatalogos { get; set; }

    public virtual DbSet<CaracteristicaEspecial> CaracteristicaEspecials { get; set; }

    public virtual DbSet<CaracteristicasxGasto> CaracteristicasxGastos { get; set; }

    public virtual DbSet<Carpeta> Carpetas { get; set; }

    public virtual DbSet<CarteraOtroSoftware> CarteraOtroSoftwares { get; set; }

    public virtual DbSet<Cartera_Abiertum> Cartera_Abierta { get; set; }

    public virtual DbSet<Cartera_Detalladum> Cartera_Detallada { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<CategoriasItem> CategoriasItems { get; set; }

    public virtual DbSet<Causacione> Causaciones { get; set; }

    public virtual DbSet<Causale> Causales { get; set; }

    public virtual DbSet<CausalesError> CausalesErrors { get; set; }

    public virtual DbSet<Certificado> Certificados { get; set; }

    public virtual DbSet<CheckDocumento> CheckDocumentos { get; set; }

    public virtual DbSet<CheckDocumentositem> CheckDocumentositems { get; set; }

    public virtual DbSet<ChequeoEspesial> ChequeoEspesials { get; set; }

    public virtual DbSet<CipExpo> CipExpos { get; set; }

    public virtual DbSet<CiudadesAduanimex> CiudadesAduanimexes { get; set; }

    public virtual DbSet<Clasificacion> Clasificacions { get; set; }

    public virtual DbSet<Clasificacion2> Clasificacion2s { get; set; }

    public virtual DbSet<ClasificacionRiesgo> ClasificacionRiesgos { get; set; }

    public virtual DbSet<ClaveRegistrada> ClaveRegistradas { get; set; }

    public virtual DbSet<CodRegimenPrecedente> CodRegimenPrecedentes { get; set; }

    public virtual DbSet<CodigoEmbalaje> CodigoEmbalajes { get; set; }

    public virtual DbSet<Columna> Columnas { get; set; }

    public virtual DbSet<ColumnasAgrupacione> ColumnasAgrupaciones { get; set; }

    public virtual DbSet<ColumnasAgrupacionesOrden> ColumnasAgrupacionesOrdens { get; set; }

    public virtual DbSet<ColumnasExportacion> ColumnasExportacions { get; set; }

    public virtual DbSet<ComentarioEntregaExportacion> ComentarioEntregaExportacions { get; set; }

    public virtual DbSet<ComisionesxEmpresa> ComisionesxEmpresas { get; set; }

    public virtual DbSet<Comisionista> Comisionistas { get; set; }

    public virtual DbSet<Compradore> Compradores { get; set; }

    public virtual DbSet<Comunicacion> Comunicacions { get; set; }

    public virtual DbSet<Confcorreoscontenedore> Confcorreoscontenedores { get; set; }

    public virtual DbSet<Configuracion> Configuracions { get; set; }

    public virtual DbSet<ConfiguracionListaChequeo> ConfiguracionListaChequeos { get; set; }

    public virtual DbSet<ConfiguracionPerfile> ConfiguracionPerfiles { get; set; }

    public virtual DbSet<ConsecutivoCotizacion> ConsecutivoCotizacions { get; set; }

    public virtual DbSet<ConsecutivoFactCiudad> ConsecutivoFactCiudads { get; set; }

    public virtual DbSet<Consulta> Consultas { get; set; }

    public virtual DbSet<ConsultaAsiscomex> ConsultaAsiscomexes { get; set; }

    public virtual DbSet<ContenedorAnticipo> ContenedorAnticipos { get; set; }

    public virtual DbSet<Contenedore> Contenedores { get; set; }

    public virtual DbSet<ContenedoresDevolucion> ContenedoresDevolucions { get; set; }

    public virtual DbSet<ContenedoresLiquidacion> ContenedoresLiquidacions { get; set; }

    public virtual DbSet<ControlCargasImportacion> ControlCargasImportacions { get; set; }

    public virtual DbSet<ControlCorreo> ControlCorreos { get; set; }

    public virtual DbSet<ControlDeposito> ControlDepositos { get; set; }

    public virtual DbSet<ControlDepositoDetalle> ControlDepositoDetalles { get; set; }

    public virtual DbSet<Correo> Correos { get; set; }

    public virtual DbSet<CorreoelectronicoxEmpresa> CorreoelectronicoxEmpresas { get; set; }

    public virtual DbSet<CorreoelectronicoxEmpresaterce> CorreoelectronicoxEmpresaterces { get; set; }

    public virtual DbSet<CostosLogistico> CostosLogisticos { get; set; }

    public virtual DbSet<Costos_Exportacione> Costos_Exportaciones { get; set; }

    public virtual DbSet<Cotizacione> Cotizaciones { get; set; }

    public virtual DbSet<Cronograma> Cronogramas { get; set; }

    public virtual DbSet<CronogramaExpo> CronogramaExpos { get; set; }

    public virtual DbSet<Cuadro> Cuadros { get; set; }

    public virtual DbSet<CuadrosItem> CuadrosItems { get; set; }

    public virtual DbSet<CuentasxPagar> CuentasxPagars { get; set; }

    public virtual DbSet<CuentasxPagar_Abiertum> CuentasxPagar_Abierta { get; set; }

    public virtual DbSet<CuposAutGlobal> CuposAutGlobals { get; set; }

    public virtual DbSet<Cxp67> Cxp67s { get; set; }

    public virtual DbSet<DETALLEFACTURASXDECLA> DETALLEFACTURASXDECLAs { get; set; }

    public virtual DbSet<DEX> Dices { get; set; }

    public virtual DbSet<DEXItem> DEXItems { get; set; }

    public virtual DbSet<DIANCIP> DIANCIPs { get; set; }

    public virtual DbSet<DO> DOs { get; set; }

    public virtual DbSet<DO_Adjunto> DO_Adjuntos { get; set; }

    public virtual DbSet<DO_Configuracion> DO_Configuracions { get; set; }

    public virtual DbSet<DO_Configuracion_Expo> DO_Configuracion_Expos { get; set; }

    public virtual DbSet<DatosTecnico> DatosTecnicos { get; set; }

    public virtual DbSet<Datosserie> Datosseries { get; set; }

    public virtual DbSet<DeclaracionAndinadelValor> DeclaracionAndinadelValors { get; set; }

    public virtual DbSet<DepartamentoDestino> DepartamentoDestinos { get; set; }

    public virtual DbSet<Deposito> Depositos { get; set; }

    public virtual DbSet<Depositoscontenedor> Depositoscontenedors { get; set; }

    public virtual DbSet<DepositoscontenedorTodo> DepositoscontenedorTodos { get; set; }

    public virtual DbSet<Despacho> Despachos { get; set; }

    public virtual DbSet<DespachoExport> DespachoExports { get; set; }

    public virtual DbSet<DespachosItem> DespachosItems { get; set; }

    public virtual DbSet<DetalleArancelDO> DetalleArancelDOs { get; set; }

    public virtual DbSet<DetalleContenedoresDO> DetalleContenedoresDOs { get; set; }

    public virtual DbSet<DetalleContenedoresdelDO> DetalleContenedoresdelDOs { get; set; }

    public virtual DbSet<DetalleDocumentosDO> DetalleDocumentosDOs { get; set; }

    public virtual DbSet<DetalleImpuestosAnticipo> DetalleImpuestosAnticipos { get; set; }

    public virtual DbSet<DetalleInformeDinamico> DetalleInformeDinamicos { get; set; }

    public virtual DbSet<DetalleMercanciasCotizacion> DetalleMercanciasCotizacions { get; set; }

    public virtual DbSet<DetalleReciboCajaAnticipo> DetalleReciboCajaAnticipos { get; set; }

    public virtual DbSet<DetalleReciboCajaMenor> DetalleReciboCajaMenors { get; set; }

    public virtual DbSet<DetalleResponsablesDO> DetalleResponsablesDOs { get; set; }

    public virtual DbSet<DetalledeDocumento> DetalledeDocumentos { get; set; }

    public virtual DbSet<Devolucion_Cliente> Devolucion_Clientes { get; set; }

    public virtual DbSet<DiferenciasEnCatalogoP> DiferenciasEnCatalogoPs { get; set; }

    public virtual DbSet<DigitalizadosHistorico> DigitalizadosHistoricos { get; set; }

    public virtual DbSet<DireccionTerritorial> DireccionTerritorials { get; set; }

    public virtual DbSet<DisposicionCarga> DisposicionCargas { get; set; }

    public virtual DbSet<DoCausalesError> DoCausalesErrors { get; set; }

    public virtual DbSet<DocTransporteExportacion> DocTransporteExportacions { get; set; }

    public virtual DbSet<Documento1> Documentos { get; set; }

    public virtual DbSet<DocumentoTransporte> DocumentoTransportes { get; set; }

    public virtual DbSet<DocumentosAdjuntosTercero> DocumentosAdjuntosTerceros { get; set; }

    public virtual DbSet<DocumentosAjuntosCliente> DocumentosAjuntosClientes { get; set; }

    public virtual DbSet<DocumentosDIAN> DocumentosDIANs { get; set; }

    public virtual DbSet<DocumentosDemora> DocumentosDemoras { get; set; }

    public virtual DbSet<DocumentosExportacion> DocumentosExportacions { get; set; }

    public virtual DbSet<DocumentosListaChequeo> DocumentosListaChequeos { get; set; }

    public virtual DbSet<Documentos_Subpartidum> Documentos_Subpartida { get; set; }

    public virtual DbSet<Documentossoporte> Documentossoportes { get; set; }

    public virtual DbSet<Embarcadore> Embarcadores { get; set; }

    public virtual DbSet<EncargadosEmpresa> EncargadosEmpresas { get; set; }

    public virtual DbSet<EncargadosEmpresasTerce> EncargadosEmpresasTerces { get; set; }

    public virtual DbSet<EnvioCorreoArriboMotonave> EnvioCorreoArriboMotonaves { get; set; }

    public virtual DbSet<EnvioCorreoArriboMotonaveAduana> EnvioCorreoArriboMotonaveAduanas { get; set; }

    public virtual DbSet<EnvioCorreoArriboMotonaveDetalle> EnvioCorreoArriboMotonaveDetalles { get; set; }

    public virtual DbSet<ErroresImpo> ErroresImpos { get; set; }

    public virtual DbSet<EstadoContenedore> EstadoContenedores { get; set; }

    public virtual DbSet<EstadoCotizacion> EstadoCotizacions { get; set; }

    public virtual DbSet<EstadoElimiadoPorDO> EstadoElimiadoPorDOs { get; set; }

    public virtual DbSet<EstadoLog> EstadoLogs { get; set; }

    public virtual DbSet<EstadoNegociosHaceb> EstadoNegociosHacebs { get; set; }

    public virtual DbSet<EstadosDo> EstadosDos { get; set; }

    public virtual DbSet<EstadosMercancium> EstadosMercancia { get; set; }

    public virtual DbSet<EstructuraBorradorSAE> EstructuraBorradorSAEs { get; set; }

    public virtual DbSet<EstructuraW> EstructuraWs { get; set; }

    public virtual DbSet<EstructuraWSIR> EstructuraWSIRs { get; set; }

    public virtual DbSet<EventoEstadoExportacione> EventoEstadoExportaciones { get; set; }

    public virtual DbSet<EventosAlerta> EventosAlertas { get; set; }

    public virtual DbSet<ExcepcionesExpo> ExcepcionesExpos { get; set; }

    public virtual DbSet<ExcepcionesImpo> ExcepcionesImpos { get; set; }

    public virtual DbSet<F560_2009_Frente> F560_2009_Frentes { get; set; }

    public virtual DbSet<FACTURASCONTROL07_> FACTURASCONTROL07_s { get; set; }

    public virtual DbSet<FXCIP> FXCIPs { get; set; }

    public virtual DbSet<Fact_Cronograma> Fact_Cronogramas { get; set; }

    public virtual DbSet<Fact_PendientexFacturarExpo> Fact_PendientexFacturarExpos { get; set; }

    public virtual DbSet<Fact_PendientexFacturarImpo> Fact_PendientexFacturarImpos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaExpoItem> FacturaExpoItems { get; set; }

    public virtual DbSet<FacturaImportacion> FacturaImportacions { get; set; }

    public virtual DbSet<FacturaReciboCaja> FacturaReciboCajas { get; set; }

    public virtual DbSet<FacturasControlJulio> FacturasControlJulios { get; set; }

    public virtual DbSet<FacturasExpo> FacturasExpos { get; set; }

    public virtual DbSet<FacturasExpoItem> FacturasExpoItems { get; set; }

    public virtual DbSet<FacturasInterfaz> FacturasInterfazs { get; set; }

    public virtual DbSet<FacturasItem> FacturasItems { get; set; }

    public virtual DbSet<FacturasTotale> FacturasTotales { get; set; }

    public virtual DbSet<FacturasTotalesControl> FacturasTotalesControls { get; set; }

    public virtual DbSet<FacturaxDeclaracion> FacturaxDeclaracions { get; set; }

    public virtual DbSet<Filtro> Filtros { get; set; }

    public virtual DbSet<FirmaAntiNarcotico> FirmaAntiNarcoticos { get; set; }

    public virtual DbSet<FirmaAntiNarcoticosDetalle> FirmaAntiNarcoticosDetalles { get; set; }

    public virtual DbSet<FormaPagoRecibo> FormaPagoRecibos { get; set; }

    public virtual DbSet<Frecuencium> Frecuencia { get; set; }

    public virtual DbSet<Gasto> Gastos { get; set; }

    public virtual DbSet<GastoAnticipo> GastoAnticipos { get; set; }

    public virtual DbSet<GastoPropioAdicionalAnticipo> GastoPropioAdicionalAnticipos { get; set; }

    public virtual DbSet<GastoPropioAnticipo> GastoPropioAnticipos { get; set; }

    public virtual DbSet<GastosConcepto> GastosConceptos { get; set; }

    public virtual DbSet<GeneracionPago> GeneracionPagos { get; set; }

    public virtual DbSet<GeneracionPagoDetalle> GeneracionPagoDetalles { get; set; }

    public virtual DbSet<GeneracionPagosCliente> GeneracionPagosClientes { get; set; }

    public virtual DbSet<Gravamene> Gravamenes { get; set; }

    public virtual DbSet<GruposAlerta> GruposAlertas { get; set; }

    public virtual DbSet<GruposAlertasUsuario> GruposAlertasUsuarios { get; set; }

    public virtual DbSet<IB_EMPLEADO> IB_EMPLEADOs { get; set; }

    public virtual DbSet<IB_IMPORTADORE> IB_IMPORTADOREs { get; set; }

    public virtual DbSet<INTERFAZ_ANTICIPOS_DETALLE> INTERFAZ_ANTICIPOS_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_ANTICIPOS_ENCABEZADO> INTERFAZ_ANTICIPOS_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_CAUSACIONE> INTERFAZ_CAUSACIONEs { get; set; }

    public virtual DbSet<INTERFAZ_CAUSACIONES_ENCABEZADO> INTERFAZ_CAUSACIONES_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_FACTURA> INTERFAZ_FACTURAs { get; set; }

    public virtual DbSet<INTERFAZ_FACTURAS_ENCABEZADO> INTERFAZ_FACTURAS_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_LEGALIZA_DETALLE> INTERFAZ_LEGALIZA_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_LEGALIZA_ENCABEZADO> INTERFAZ_LEGALIZA_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_NC_DETALLE> INTERFAZ_NC_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_NC_ENCABEZADO> INTERFAZ_NC_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_ND_DETALLE> INTERFAZ_ND_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_ND_ENCABEZADO> INTERFAZ_ND_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_RC_DETALLE> INTERFAZ_RC_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_RC_ENCABEZADO> INTERFAZ_RC_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_RECIBOS_DETALLE> INTERFAZ_RECIBOS_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_RECIBOS_ENCABEZADO> INTERFAZ_RECIBOS_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_SF_DETALLE> INTERFAZ_SF_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_SF_ENCABEZADO> INTERFAZ_SF_ENCABEZADOs { get; set; }

    public virtual DbSet<INTERFAZ_TE2_DETALLE> INTERFAZ_TE2_DETALLEs { get; set; }

    public virtual DbSet<INTERFAZ_TE2_ENCABEZADO> INTERFAZ_TE2_ENCABEZADOs { get; set; }

    public virtual DbSet<IVA> IVAs { get; set; }

    public virtual DbSet<IdentificacionONU> IdentificacionONUs { get; set; }

    public virtual DbSet<IdentificacionRiesgo> IdentificacionRiesgos { get; set; }

    public virtual DbSet<Imputacione> Imputaciones { get; set; }

    public virtual DbSet<ImputacionesContable> ImputacionesContables { get; set; }

    public virtual DbSet<IndicadorCicloFacturacion> IndicadorCicloFacturacions { get; set; }

    public virtual DbSet<IndicadorCicloFacturacionAgrupado> IndicadorCicloFacturacionAgrupados { get; set; }

    public virtual DbSet<IndicadorExportacionDetalle> IndicadorExportacionDetalles { get; set; }

    public virtual DbSet<IndicadorOperacionOportuna> IndicadorOperacionOportunas { get; set; }

    public virtual DbSet<IndicadorOperacionOportunaAgrupado> IndicadorOperacionOportunaAgrupados { get; set; }

    public virtual DbSet<Indicadore> Indicadores { get; set; }

    public virtual DbSet<IndicadoresEstado> IndicadoresEstados { get; set; }

    public virtual DbSet<IndicadoresExportacion> IndicadoresExportacions { get; set; }

    public virtual DbSet<IndicadoresSeguimiento> IndicadoresSeguimientos { get; set; }

    public virtual DbSet<Indirecto> Indirectos { get; set; }

    public virtual DbSet<InformeDinamico> InformeDinamicos { get; set; }

    public virtual DbSet<InformeIsa20Mayo_Crystal_Hada_Impo> InformeIsa20Mayo_Crystal_Hada_Impos { get; set; }

    public virtual DbSet<InformeIsa20Mayo_Crystal_Hadum> InformeIsa20Mayo_Crystal_Hada { get; set; }

    public virtual DbSet<Informe_De_Elaboracion> Informe_De_Elaboracions { get; set; }

    public virtual DbSet<Informe_De_Elaboracion2> Informe_De_Elaboracion2s { get; set; }

    public virtual DbSet<Informe_Uap_Aduanimex> Informe_Uap_Aduanimexes { get; set; }

    public virtual DbSet<InformereciboCajaAnticipo> InformereciboCajaAnticipos { get; set; }

    public virtual DbSet<InformereciboCajaOtro> InformereciboCajaOtros { get; set; }

    public virtual DbSet<InstruccionesDetalle> InstruccionesDetalles { get; set; }

    public virtual DbSet<IntegracionControl> IntegracionControls { get; set; }

    public virtual DbSet<Interfaz_Control> Interfaz_Controls { get; set; }

    public virtual DbSet<Interfaz_ControlHistorico> Interfaz_ControlHistoricos { get; set; }

    public virtual DbSet<Intermediario> Intermediarios { get; set; }

    public virtual DbSet<ItemsTarifario> ItemsTarifarios { get; set; }

    public virtual DbSet<Kit> Kits { get; set; }

    public virtual DbSet<LOG_Liquidacion> LOG_Liquidacions { get; set; }

    public virtual DbSet<LegalizacionesSinTransferencia> LegalizacionesSinTransferencias { get; set; }

    public virtual DbSet<LeoConsecutivo> LeoConsecutivos { get; set; }

    public virtual DbSet<LetrasPermitida> LetrasPermitidas { get; set; }

    public virtual DbSet<LineaTiempo> LineaTiempos { get; set; }

    public virtual DbSet<LiquidaMadecentro1> LiquidaMadecentro1s { get; set; }

    public virtual DbSet<LiquidacionExportacion> LiquidacionExportacions { get; set; }

    public virtual DbSet<LiquidacionPrebel> LiquidacionPrebels { get; set; }

    public virtual DbSet<LiquidacionPrebelEncabezado> LiquidacionPrebelEncabezados { get; set; }

    public virtual DbSet<LiquidacionPrebelItem> LiquidacionPrebelItems { get; set; }

    public virtual DbSet<Liquidacion_LeonisaConcepto> Liquidacion_LeonisaConceptos { get; set; }

    public virtual DbSet<LiquidacionesExpoItem> LiquidacionesExpoItems { get; set; }

    public virtual DbSet<ListaChequeoEncabezado> ListaChequeoEncabezados { get; set; }

    public virtual DbSet<ListadoFactura> ListadoFacturas { get; set; }

    public virtual DbSet<Listaempaque> Listaempaques { get; set; }

    public virtual DbSet<Listaempaquedetalle> Listaempaquedetalles { get; set; }

    public virtual DbSet<LogFacturacionElectronica> LogFacturacionElectronicas { get; set; }

    public virtual DbSet<LogRegistroMuisca> LogRegistroMuiscas { get; set; }

    public virtual DbSet<LogTransaccione> LogTransacciones { get; set; }

    public virtual DbSet<LugarDestinoFinal> LugarDestinoFinals { get; set; }

    public virtual DbSet<LugarIngresoMercancia> LugarIngresoMercancias { get; set; }

    public virtual DbSet<Madecentro_Gasto> Madecentro_Gastos { get; set; }

    public virtual DbSet<Madecentro_GastosDetalle> Madecentro_GastosDetalles { get; set; }

    public virtual DbSet<Madecentro_ProximoLevante> Madecentro_ProximoLevantes { get; set; }

    public virtual DbSet<Madecentro_SinAsignacion> Madecentro_SinAsignacions { get; set; }

    public virtual DbSet<MasivoSubpartida> MasivoSubpartidas { get; set; }

    public virtual DbSet<MedidaProducto> MedidaProductos { get; set; }

    public virtual DbSet<MedidasCotizacion> MedidasCotizacions { get; set; }

    public virtual DbSet<Mercado> Mercados { get; set; }

    public virtual DbSet<Minima> Minimas { get; set; }

    public virtual DbSet<MinimaDetalle> MinimaDetalles { get; set; }

    public virtual DbSet<MinimasCatalogoP> MinimasCatalogoPs { get; set; }

    public virtual DbSet<MinimasCatalogoPImpo> MinimasCatalogoPImpos { get; set; }

    public virtual DbSet<MinimasEncabezado> MinimasEncabezados { get; set; }

    public virtual DbSet<MinimasHistorico> MinimasHistoricos { get; set; }

    public virtual DbSet<MinimasRelacion> MinimasRelacions { get; set; }

    public virtual DbSet<Modalidad> Modalidads { get; set; }

    public virtual DbSet<Modalidade> Modalidades { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Naviera> Navieras { get; set; }

    public virtual DbSet<NotaRemisoriadetalle> NotaRemisoriadetalles { get; set; }

    public virtual DbSet<NotaRemisorium> NotaRemisoria { get; set; }

    public virtual DbSet<NotasCreditoDebito> NotasCreditoDebitos { get; set; }

    public virtual DbSet<NotasCreditoDebitoTercero> NotasCreditoDebitoTerceros { get; set; }

    public virtual DbSet<NotasReciboCaja> NotasReciboCajas { get; set; }

    public virtual DbSet<Notificacione> Notificaciones { get; set; }

    public virtual DbSet<NotificacionesLeidasUsuario> NotificacionesLeidasUsuarios { get; set; }

    public virtual DbSet<Novedad> Novedads { get; set; }

    public virtual DbSet<NovedadUsuario> NovedadUsuarios { get; set; }

    public virtual DbSet<NrosplanillaT> NrosplanillaTs { get; set; }

    public virtual DbSet<NumerosEnvio> NumerosEnvios { get; set; }

    public virtual DbSet<NumerosEnvioPlanilla> NumerosEnvioPlanillas { get; set; }

    public virtual DbSet<ObservacionesModalidad> ObservacionesModalidads { get; set; }

    public virtual DbSet<OficinasComercializadora> OficinasComercializadoras { get; set; }

    public virtual DbSet<OficinasOperativa> OficinasOperativas { get; set; }

    public virtual DbSet<OpcionesxPerfil> OpcionesxPerfils { get; set; }

    public virtual DbSet<Operacione> Operaciones { get; set; }

    public virtual DbSet<OperacionesDO> OperacionesDOs { get; set; }

    public virtual DbSet<OperacionesEXPO> OperacionesEXPOs { get; set; }

    public virtual DbSet<OperacionesExportacion> OperacionesExportacions { get; set; }

    public virtual DbSet<OperacionesExportacionDetalle> OperacionesExportacionDetalles { get; set; }

    public virtual DbSet<OperacionesImpoDTum> OperacionesImpoDTAs { get; set; }

    public virtual DbSet<OperadorxEmpresa> OperadorxEmpresas { get; set; }

    public virtual DbSet<OrdenServicio> OrdenServicios { get; set; }

    public virtual DbSet<Ordendecompra> Ordendecompras { get; set; }

    public virtual DbSet<Ordendecompraitem> Ordendecompraitems { get; set; }

    public virtual DbSet<PROSALON> PROSALONs { get; set; }

    public virtual DbSet<PRUEBADBMLBORRAR> PRUEBADBMLBORRARs { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<PagosChequeAutorizacione> PagosChequeAutorizaciones { get; set; }

    public virtual DbSet<PalabrasEspeciale> PalabrasEspeciales { get; set; }

    public virtual DbSet<PlaneacionTransporte> PlaneacionTransportes { get; set; }

    public virtual DbSet<PlanoPagosSeleccion> PlanoPagosSeleccions { get; set; }

    public virtual DbSet<PlanoPagosSeleccionCliente> PlanoPagosSeleccionClientes { get; set; }

    public virtual DbSet<Poliza> Polizas { get; set; }

    public virtual DbSet<PrefiltrosReporte> PrefiltrosReportes { get; set; }

    public virtual DbSet<Preliquidacion> Preliquidacions { get; set; }

    public virtual DbSet<ProcesoAnticipo> ProcesoAnticipos { get; set; }

    public virtual DbSet<ProcesoAnticipoDetalle> ProcesoAnticipoDetalles { get; set; }

    public virtual DbSet<ProcesoGastoAnticipo> ProcesoGastoAnticipos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosEliminado> ProductosEliminados { get; set; }

    public virtual DbSet<ProductosEliminadosimpo> ProductosEliminadosimpos { get; set; }

    public virtual DbSet<Propuestaproducto> Propuestaproductos { get; set; }

    public virtual DbSet<ProveedoresImportadore> ProveedoresImportadores { get; set; }

    public virtual DbSet<RadicadoMuisca> RadicadoMuiscas { get; set; }

    public virtual DbSet<RadicadosEdiFac> RadicadosEdiFacs { get; set; }

    public virtual DbSet<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; }

    public virtual DbSet<ReciboCajaMenor> ReciboCajaMenors { get; set; }

    public virtual DbSet<RecibosCajaFactura> RecibosCajaFacturas { get; set; }

    public virtual DbSet<Reembolso> Reembolsos { get; set; }

    public virtual DbSet<Regione> Regiones { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<RegistroImportacion> RegistroImportacions { get; set; }

    public virtual DbSet<RegistroImportacionItemsCom> RegistroImportacionItemsComs { get; set; }

    public virtual DbSet<RegistroImportacionesItem> RegistroImportacionesItems { get; set; }

    public virtual DbSet<RelacionCajaMenor> RelacionCajaMenors { get; set; }

    public virtual DbSet<RelacionDefecto> RelacionDefectos { get; set; }

    public virtual DbSet<RelacionFormulario> RelacionFormularios { get; set; }

    public virtual DbSet<RelacionGasto> RelacionGastos { get; set; }

    public virtual DbSet<RelacionGastosItem> RelacionGastosItems { get; set; }

    public virtual DbSet<RelacionesInformeDinamico> RelacionesInformeDinamicos { get; set; }

    public virtual DbSet<ReportDeclaracionImportacion> ReportDeclaracionImportacions { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<ReportesColumna> ReportesColumnas { get; set; }

    public virtual DbSet<ReportesUsuario> ReportesUsuarios { get; set; }

    public virtual DbSet<RespuestasSincronizacionMalco> RespuestasSincronizacionMalcos { get; set; }

    public virtual DbSet<Reteiva> Reteivas { get; set; }

    public virtual DbSet<RutasNombreDO> RutasNombreDOs { get; set; }

    public virtual DbSet<SIA> SIAs { get; set; }

    public virtual DbSet<SaldoDO> SaldoDOs { get; set; }

    public virtual DbSet<SaldosAFavor> SaldosAFavors { get; set; }

    public virtual DbSet<SegmentosEDIFAC> SegmentosEDIFACs { get; set; }

    public virtual DbSet<Seguimiento> Seguimientos { get; set; }

    public virtual DbSet<SeguimientoItem> SeguimientoItems { get; set; }

    public virtual DbSet<SeguimientoItemEvento> SeguimientoItemEventos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServiciosPorDO> ServiciosPorDOs { get; set; }

    public virtual DbSet<ServiciosPorTarifa> ServiciosPorTarifas { get; set; }

    public virtual DbSet<ServiciosxEmpresa> ServiciosxEmpresas { get; set; }

    public virtual DbSet<SigloXXISubpartida> SigloXXISubpartidas { get; set; }

    public virtual DbSet<Signatario> Signatarios { get; set; }

    public virtual DbSet<SignatarioDTum> SignatarioDTAs { get; set; }

    public virtual DbSet<SituacionDO> SituacionDOs { get; set; }

    public virtual DbSet<Situacion_Negocio> Situacion_Negocios { get; set; }

    public virtual DbSet<SolicitudCliente> SolicitudClientes { get; set; }

    public virtual DbSet<SoporteDim> SoporteDims { get; set; }

    public virtual DbSet<SubpartidasComplemento> SubpartidasComplementos { get; set; }

    public virtual DbSet<SubpartidasSigloXXI> SubpartidasSigloXXIs { get; set; }

    public virtual DbSet<Suceso> Sucesos { get; set; }

    public virtual DbSet<SucesosLectura> SucesosLecturas { get; set; }

    public virtual DbSet<TEMPORALDESMINIMA> TEMPORALDESMINIMAs { get; set; }

    public virtual DbSet<TEMPORALDESTINATARIO> TEMPORALDESTINATARIOs { get; set; }

    public virtual DbSet<TEMPORALEMPRESASNAT> TEMPORALEMPRESASNATs { get; set; }

    public virtual DbSet<TEMPORALIMPORTADORESDEF> TEMPORALIMPORTADORESDEFs { get; set; }

    public virtual DbSet<TEMPORALMINIMARELACION> TEMPORALMINIMARELACIONs { get; set; }

    public virtual DbSet<TEMPORALSEGURO> TEMPORALSEGUROs { get; set; }

    public virtual DbSet<TEMPORALSUB> TEMPORALSUBs { get; set; }

    public virtual DbSet<TEMPORALSUBPARTIDA> TEMPORALSUBPARTIDAs { get; set; }

    public virtual DbSet<TEMPO_IMPORTADORE> TEMPO_IMPORTADOREs { get; set; }

    public virtual DbSet<TEMPO_PROVEEDORE> TEMPO_PROVEEDOREs { get; set; }

    public virtual DbSet<TEMPO_TRANSPINTERNACIONALE> TEMPO_TRANSPINTERNACIONALEs { get; set; }

    public virtual DbSet<TablaNuevo> TablaNuevos { get; set; }

    public virtual DbSet<TablaTviejo> TablaTviejos { get; set; }

    public virtual DbSet<TamanioContenedorFull> TamanioContenedorFulls { get; set; }

    public virtual DbSet<TamanoContenedor> TamanoContenedors { get; set; }

    public virtual DbSet<TarifaMaster> TarifaMasters { get; set; }

    public virtual DbSet<TarifaMasterItem> TarifaMasterItems { get; set; }

    public virtual DbSet<Tarifario> Tarifarios { get; set; }

    public virtual DbSet<TarifarioAdjunto> TarifarioAdjuntos { get; set; }

    public virtual DbSet<TarifarioContenedor> TarifarioContenedors { get; set; }

    public virtual DbSet<TarifarioContenedorCE> TarifarioContenedorCEs { get; set; }

    public virtual DbSet<TarifarioContenedoritem> TarifarioContenedoritems { get; set; }

    public virtual DbSet<TarifarioItem> TarifarioItems { get; set; }

    public virtual DbSet<TarifarioTerrestre> TarifarioTerrestres { get; set; }

    public virtual DbSet<TarifarioTerrestreItem> TarifarioTerrestreItems { get; set; }

    public virtual DbSet<TarifasControl> TarifasControls { get; set; }

    public virtual DbSet<TarifasCotizacion> TarifasCotizacions { get; set; }

    public virtual DbSet<Tb_ConsecutivoCotizacione> Tb_ConsecutivoCotizaciones { get; set; }

    public virtual DbSet<Tb_ConsecutivoTarifaMaster> Tb_ConsecutivoTarifaMasters { get; set; }

    public virtual DbSet<Tb_ConsecutivoTarifario> Tb_ConsecutivoTarifarios { get; set; }

    public virtual DbSet<TempoCartera> TempoCarteras { get; set; }

    public virtual DbSet<TempoCip> TempoCips { get; set; }

    public virtual DbSet<TempoCip1> TempoCips1 { get; set; }

    public virtual DbSet<TempoCuentasxCobrarAd> TempoCuentasxCobrarAds { get; set; }

    public virtual DbSet<TempoCxP> TempoCxPs { get; set; }

    public virtual DbSet<TempoCxP2> TempoCxP2s { get; set; }

    public virtual DbSet<TempoKit> TempoKits { get; set; }

    public virtual DbSet<TempoProvee> TempoProvees { get; set; }

    public virtual DbSet<TemporalClasificacion> TemporalClasificacions { get; set; }

    public virtual DbSet<TemporalConcepto> TemporalConceptos { get; set; }

    public virtual DbSet<TemporalEtiqueta> TemporalEtiquetas { get; set; }

    public virtual DbSet<Temporalvistosbuenosxsubp> Temporalvistosbuenosxsubps { get; set; }

    public virtual DbSet<Tercero> Terceros { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoEquipo> TipoEquipos { get; set; }

    public virtual DbSet<TipoEstado> TipoEstados { get; set; }

    public virtual DbSet<TipoImportacion> TipoImportacions { get; set; }

    public virtual DbSet<TipoNegociacion> TipoNegociacions { get; set; }

    public virtual DbSet<TiposDeDocumento> TiposDeDocumentos { get; set; }

    public virtual DbSet<TransportadorNacional> TransportadorNacionals { get; set; }

    public virtual DbSet<TransporteTerrestre> TransporteTerrestres { get; set; }

    public virtual DbSet<TransporteTerrestreDetalle> TransporteTerrestreDetalles { get; set; }

    public virtual DbSet<Traslado> Traslados { get; set; }

    public virtual DbSet<TrasladosAnexo> TrasladosAnexos { get; set; }

    public virtual DbSet<TrazabilidadNovaTrack> TrazabilidadNovaTracks { get; set; }

    public virtual DbSet<Trm> Trms { get; set; }

    public virtual DbSet<TrmHistorico> TrmHistoricos { get; set; }

    public virtual DbSet<UnidadCarga> UnidadCargas { get; set; }

    public virtual DbSet<UsuarioMuisca> UsuarioMuiscas { get; set; }

    public virtual DbSet<UsuarioSigloXXI> UsuarioSigloXXIs { get; set; }

    public virtual DbSet<UsuarioSigloXXIDetalle> UsuarioSigloXXIDetalles { get; set; }

    public virtual DbSet<UsuariosControl> UsuariosControls { get; set; }

    public virtual DbSet<UsuariosOnLine> UsuariosOnLines { get; set; }

    public virtual DbSet<ValidacionIndicadore> ValidacionIndicadores { get; set; }

    public virtual DbSet<ValoresGasto> ValoresGastos { get; set; }

    public virtual DbSet<VinculoDocumentosExpo> VinculoDocumentosExpos { get; set; }

    public virtual DbSet<VinculoDocumentosImpo> VinculoDocumentosImpos { get; set; }

    public virtual DbSet<VistosBueno> VistosBuenos { get; set; }

    public virtual DbSet<VistosBuenosMincomercio> VistosBuenosMincomercios { get; set; }

    public virtual DbSet<VistosBuenosXSubpartidum> VistosBuenosXSubpartida { get; set; }

    public virtual DbSet<VueltasMensajerium> VueltasMensajeria { get; set; }

    public virtual DbSet<actividadeconomica> actividadeconomicas { get; set; }

    public virtual DbSet<acuerdo> acuerdos { get; set; }

    public virtual DbSet<acuerdos_subpartida> acuerdos_subpartidas { get; set; }

    public virtual DbSet<aduana> aduanas { get; set; }

    public virtual DbSet<agentesenelexterior> agentesenelexteriors { get; set; }

    public virtual DbSet<autorizacionembarque> autorizacionembarques { get; set; }

    public virtual DbSet<borrarmedidum> borrarmedida { get; set; }

    public virtual DbSet<borrarservicio> borrarservicios { get; set; }

    public virtual DbSet<causacionescontenedore> causacionescontenedores { get; set; }

    public virtual DbSet<causacionesencabezado> causacionesencabezados { get; set; }

    public virtual DbSet<causacionesencabezadoanticipo> causacionesencabezadoanticipos { get; set; }

    public virtual DbSet<causacionesitem> causacionesitems { get; set; }

    public virtual DbSet<causacionesitemsanticipo> causacionesitemsanticipos { get; set; }

    public virtual DbSet<causacionesreporte> causacionesreportes { get; set; }

    public virtual DbSet<claseembalaje> claseembalajes { get; set; }

    public virtual DbSet<comisionesxempresadetalle> comisionesxempresadetalles { get; set; }

    public virtual DbSet<consecutivocausacion> consecutivocausacions { get; set; }

    public virtual DbSet<consignatario> consignatarios { get; set; }

    public virtual DbSet<controlfacturacion> controlfacturacions { get; set; }

    public virtual DbSet<controlfacturacionitem> controlfacturacionitems { get; set; }

    public virtual DbSet<correostercero> correosterceros { get; set; }

    public virtual DbSet<correspondenciaSucursal> correspondenciaSucursals { get; set; }

    public virtual DbSet<costo> costos { get; set; }

    public virtual DbSet<cuadros_insumos_producto> cuadros_insumos_productos { get; set; }

    public virtual DbSet<cuentasbancaria> cuentasbancarias { get; set; }

    public virtual DbSet<cuentasbancariasterce> cuentasbancariasterces { get; set; }

    public virtual DbSet<cuentasbancariastercero> cuentasbancariasterceros { get; set; }

    public virtual DbSet<declaracionImportacion> declaracionImportacions { get; set; }

    public virtual DbSet<declaracione> declaraciones { get; set; }

    public virtual DbSet<declaracionesitem> declaracionesitems { get; set; }

    public virtual DbSet<declarante> declarantes { get; set; }

    public virtual DbSet<depositohabilitado> depositohabilitados { get; set; }

    public virtual DbSet<descripcionpartida> descripcionpartidas { get; set; }

    public virtual DbSet<descripcionsubpartida> descripcionsubpartidas { get; set; }

    public virtual DbSet<destinatario> destinatarios { get; set; }

    public virtual DbSet<detalledeclaimpo> detalledeclaimpos { get; set; }

    public virtual DbSet<detalledeclaracionandinadelvalor> detalledeclaracionandinadelvalors { get; set; }

    public virtual DbSet<detallefacturacionControl> detallefacturacionControls { get; set; }

    public virtual DbSet<detallefacturaimportacion> detallefacturaimportacions { get; set; }

    public virtual DbSet<documento> documentos { get; set; }

    public virtual DbSet<documentoDetalle> documentoDetalles { get; set; }

    public virtual DbSet<documentotransportedetallecontenedore> documentotransportedetallecontenedores { get; set; }

    public virtual DbSet<documentotransportedetallemercancia> documentotransportedetallemercancias { get; set; }

    public virtual DbSet<encabezadoleonisa> encabezadoleonisas { get; set; }

    public virtual DbSet<eu> eus { get; set; }

    public virtual DbSet<eventoEstado> eventoEstados { get; set; }

    public virtual DbSet<exportador> exportadors { get; set; }

    public virtual DbSet<exportadornegociacion> exportadornegociacions { get; set; }

    public virtual DbSet<facturacionaduana> facturacionaduanas { get; set; }

    public virtual DbSet<facturacionaduanadetalle> facturacionaduanadetalles { get; set; }

    public virtual DbSet<facturaexpo> facturaexpos { get; set; }

    public virtual DbSet<formapago> formapagos { get; set; }

    public virtual DbSet<generacionPagoDetalleCliente> generacionPagoDetalleClientes { get; set; }

    public virtual DbSet<impoporembar> impoporembars { get; set; }

    public virtual DbSet<impoporproveedor> impoporproveedors { get; set; }

    public virtual DbSet<importadore> importadores { get; set; }

    public virtual DbSet<importadores_ib_final> importadores_ib_finals { get; set; }

    public virtual DbSet<impprovref> impprovrefs { get; set; }

    public virtual DbSet<impresora> impresoras { get; set; }

    public virtual DbSet<incoterm> incoterms { get; set; }

    public virtual DbSet<informeFacturacion> informeFacturacions { get; set; }

    public virtual DbSet<informecontenedore> informecontenedores { get; set; }

    public virtual DbSet<instruccione> instrucciones { get; set; }

    public virtual DbSet<instruccionesdespacho> instruccionesdespachos { get; set; }

    public virtual DbSet<insumo> insumos { get; set; }

    public virtual DbSet<interfaz_control2> interfaz_control2s { get; set; }

    public virtual DbSet<liquidacion_leonisa> liquidacion_leonisas { get; set; }

    public virtual DbSet<liquidacion_leonisadetalle> liquidacion_leonisadetalles { get; set; }

    public virtual DbSet<liquidacionleonisa> liquidacionleonisas { get; set; }

    public virtual DbSet<logRobotSiglo> logRobotSiglos { get; set; }

    public virtual DbSet<logTransaccionCambioDo> logTransaccionCambioDos { get; set; }

    public virtual DbSet<logUsuarioClave> logUsuarioClaves { get; set; }

    public virtual DbSet<lugardestino> lugardestinos { get; set; }

    public virtual DbSet<lugarembarque> lugarembarques { get; set; }

    public virtual DbSet<lugarinspeccion> lugarinspeccions { get; set; }

    public virtual DbSet<message> messages { get; set; }

    public virtual DbSet<migracionotek> migracionoteks { get; set; }

    public virtual DbSet<migracionotekdirecto> migracionotekdirectos { get; set; }

    public virtual DbSet<migracionoteksisesp> migracionoteksisesps { get; set; }

    public virtual DbSet<minimas1> minimas1s { get; set; }

    public virtual DbSet<minimas2> minimas2s { get; set; }

    public virtual DbSet<minimas3> minimas3s { get; set; }

    public virtual DbSet<modotransporte> modotransportes { get; set; }

    public virtual DbSet<moneda> monedas { get; set; }

    public virtual DbSet<naturalezatransaccion> naturalezatransaccions { get; set; }

    public virtual DbSet<naturalezatransaccionimpo> naturalezatransaccionimpos { get; set; }

    public virtual DbSet<negociacione> negociaciones { get; set; }

    public virtual DbSet<notacredito> notacreditos { get; set; }

    public virtual DbSet<nrosFraccionada> nrosFraccionadas { get; set; }

    public virtual DbSet<nrosreservado> nrosreservados { get; set; }

    public virtual DbSet<ordendecompradetalle> ordendecompradetalles { get; set; }

    public virtual DbSet<paise> paises { get; set; }

    public virtual DbSet<parametro> parametros { get; set; }

    public virtual DbSet<pedidodecompra> pedidodecompras { get; set; }

    public virtual DbSet<pedidodecompraitem> pedidodecompraitems { get; set; }

    public virtual DbSet<perfile> perfiles { get; set; }

    public virtual DbSet<planillatraslado> planillatraslados { get; set; }

    public virtual DbSet<planillatrasladoitem> planillatrasladoitems { get; set; }

    public virtual DbSet<preferenciaarancelarium> preferenciaarancelaria { get; set; }

    public virtual DbSet<productoscrystal> productoscrystals { get; set; }

    public virtual DbSet<productosib> productosibs { get; set; }

    public virtual DbSet<productosibcontrol> productosibcontrols { get; set; }

    public virtual DbSet<productosimpo> productosimpos { get; set; }

    public virtual DbSet<productosimpoHistorico> productosimpoHistoricos { get; set; }

    public virtual DbSet<programador> programadors { get; set; }

    public virtual DbSet<programadordetallecontenedor> programadordetallecontenedors { get; set; }

    public virtual DbSet<promediodemora> promediodemoras { get; set; }

    public virtual DbSet<proveedore> proveedores { get; set; }

    public virtual DbSet<proveedores_ib_final_> proveedores_ib_final_s { get; set; }

    public virtual DbSet<proveedoreshistorico> proveedoreshistoricos { get; set; }

    public virtual DbSet<proveedoresib> proveedoresibs { get; set; }

    public virtual DbSet<puertoembarque> puertoembarques { get; set; }

    public virtual DbSet<pvt> pvts { get; set; }

    public virtual DbSet<regimenaduanero> regimenaduaneros { get; set; }

    public virtual DbSet<regimenprecedente> regimenprecedentes { get; set; }

    public virtual DbSet<regionprocedencium> regionprocedencia { get; set; }

    public virtual DbSet<relacionpago> relacionpagos { get; set; }

    public virtual DbSet<seguimientodespacho> seguimientodespachos { get; set; }

    public virtual DbSet<sellosykit> sellosykits { get; set; }

    public virtual DbSet<sistemasEspCatalogoP> sistemasEspCatalogoPs { get; set; }

    public virtual DbSet<sistemasespeciale> sistemasespeciales { get; set; }

    public virtual DbSet<solicitudclientedato> solicitudclientedatos { get; set; }

    public virtual DbSet<subpartida> subpartidas { get; set; }

    public virtual DbSet<subpartidaib> subpartidaibs { get; set; }

    public virtual DbSet<subproceso> subprocesos { get; set; }

    public virtual DbSet<subprocesosdetalle> subprocesosdetalles { get; set; }

    public virtual DbSet<tbCiudad> tbCiudads { get; set; }

    public virtual DbSet<tbDeclaracionExportacion> tbDeclaracionExportacions { get; set; }

    public virtual DbSet<tbDepartamento> tbDepartamentos { get; set; }

    public virtual DbSet<tbEntregaMciaExpo> tbEntregaMciaExpos { get; set; }

    public virtual DbSet<tbEntregaMciaItemExpo> tbEntregaMciaItemExpos { get; set; }

    public virtual DbSet<tbEntregaMcium> tbEntregaMcia { get; set; }

    public virtual DbSet<tbRegistro> tbRegistros { get; set; }

    public virtual DbSet<tbRegistrosItem> tbRegistrosItems { get; set; }

    public virtual DbSet<tb_ActividadEconomicaRut> tb_ActividadEconomicaRuts { get; set; }

    public virtual DbSet<tb_CaracteristicasxGastosPropio> tb_CaracteristicasxGastosPropios { get; set; }

    public virtual DbSet<tb_ConcecutivoDO> tb_ConcecutivoDOs { get; set; }

    public virtual DbSet<tb_ConsecutivoDTum> tb_ConsecutivoDTAs { get; set; }

    public virtual DbSet<tb_Consecutivos_DAV> tb_Consecutivos_DAVs { get; set; }

    public virtual DbSet<tb_DTum> tb_DTAs { get; set; }

    public virtual DbSet<tb_DetalleDTum> tb_DetalleDTAs { get; set; }

    public virtual DbSet<tb_LiquidacionLCL> tb_LiquidacionLCLs { get; set; }

    public virtual DbSet<tb_NegociacionxEmpresa> tb_NegociacionxEmpresas { get; set; }

    public virtual DbSet<tb_RepresentanteTransportador> tb_RepresentanteTransportadors { get; set; }

    public virtual DbSet<tb_TarifarioPortuario> tb_TarifarioPortuarios { get; set; }

    public virtual DbSet<tb_Temp_det_DAV> tb_Temp_det_DAVs { get; set; }

    public virtual DbSet<tb_TransitoAduanero> tb_TransitoAduaneros { get; set; }

    public virtual DbSet<tb_TransitoAduaneroDetalle> tb_TransitoAduaneroDetalles { get; set; }

    public virtual DbSet<tb_XMLGenerado> tb_XMLGenerados { get; set; }

    public virtual DbSet<tb_liquidacionAnticipo> tb_liquidacionAnticipos { get; set; }

    public virtual DbSet<tb_log_transac> tb_log_transacs { get; set; }

    public virtual DbSet<tb_perfilesxusuario> tb_perfilesxusuarios { get; set; }

    public virtual DbSet<tb_tarifarioPortDetalle> tb_tarifarioPortDetalles { get; set; }

    public virtual DbSet<tb_tempProductoImpo> tb_tempProductoImpos { get; set; }

    public virtual DbSet<telefonosporempresa> telefonosporempresas { get; set; }

    public virtual DbSet<telefonosporempresaterce> telefonosporempresaterces { get; set; }

    public virtual DbSet<temponit> temponits { get; set; }

    public virtual DbSet<tiempoliberacion> tiempoliberacions { get; set; }

    public virtual DbSet<tiempovaciado> tiempovaciados { get; set; }

    public virtual DbSet<tipocarga> tipocargas { get; set; }

    public virtual DbSet<tipodato> tipodatos { get; set; }

    public virtual DbSet<tipodeoperacion> tipodeoperacions { get; set; }

    public virtual DbSet<tipodocumentosoporte> tipodocumentosoportes { get; set; }

    public virtual DbSet<tipoembarque> tipoembarques { get; set; }

    public virtual DbSet<tiposolicitud> tiposolicituds { get; set; }

    public virtual DbSet<transferenciaCuentum> transferenciaCuenta { get; set; }

    public virtual DbSet<transportador> transportadors { get; set; }

    public virtual DbSet<transportadores_ib_final_> transportadores_ib_final_s { get; set; }

    public virtual DbSet<trazabilidad_logistica> trazabilidad_logisticas { get; set; }

    public virtual DbSet<trmexportador> trmexportadors { get; set; }

    public virtual DbSet<unidadcomercial> unidadcomercials { get; set; }

    public virtual DbSet<unidaddian> unidaddians { get; set; }

    public virtual DbSet<unidade> unidades { get; set; }

    public virtual DbSet<unidadmedidaplazo> unidadmedidaplazos { get; set; }

    public virtual DbSet<usuario> usuarios { get; set; }

    public virtual DbSet<usuariosU> usuariosUs { get; set; }

    public virtual DbSet<vPlaneador> vPlaneadors { get; set; }

    public virtual DbSet<vPlaneadorExportacione> vPlaneadorExportaciones { get; set; }

    public virtual DbSet<v_Documento> v_Documentos { get; set; }

    public virtual DbSet<v_Impresora> v_Impresoras { get; set; }

    public virtual DbSet<v_Variable> v_Variables { get; set; }

    public virtual DbSet<v_documentodetalle> v_documentodetalles { get; set; }

    public virtual DbSet<v_variableDocumentoImpresoraDetalle> v_variableDocumentoImpresoraDetalles { get; set; }

    public virtual DbSet<variableDocumentoImpresora> variableDocumentoImpresoras { get; set; }

    public virtual DbSet<variableDocumentoImpresoraDetalle> variableDocumentoImpresoraDetalles { get; set; }

    public virtual DbSet<via> vias { get; set; }

    public virtual DbSet<vistosBuenosxProducto> vistosBuenosxProductos { get; set; }

    public virtual DbSet<vistosbuenositem> vistosbuenositems { get; set; }

    public virtual DbSet<zonafranca> zonafrancas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AMX>(entity =>
        {
            entity.HasKey(e => e.idTransmision).HasName("PK_Table_1");

            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Activacionalerta>(entity =>
        {
            entity.HasKey(e => e.idactivacionalertas).HasFillFactor(90);
        });

        modelBuilder.Entity<Actividade>(entity =>
        {
            entity.HasKey(e => e.idActividades).HasName("PK__Activida__8C6AC6BB28ED12D1");

            entity.HasOne(d => d.DocumentoNavigation).WithMany(p => p.Actividades).HasConstraintName("FK__Actividad__Docum__5105F123");
        });

        modelBuilder.Entity<ActividadesListaChequeo>(entity =>
        {
            entity.HasKey(e => e.idActividadesListaChequeo).HasName("PK__Activida__7B5B4D1C251C81ED");

            entity.HasOne(d => d.idActividadNavigation).WithMany(p => p.ActividadesListaChequeos).HasConstraintName("FK__Actividad__idAct__51FA155C");

            entity.HasOne(d => d.idListaChequeoEncabezadoNavigation).WithMany(p => p.ActividadesListaChequeos).HasConstraintName("FK__Actividad__idLis__52EE3995");
        });

        modelBuilder.Entity<AcuerdosInternacionale>(entity =>
        {
            entity.HasKey(e => e.idAcuerdo).HasFillFactor(90);

            entity.Property(e => e.fechaultimaactualizacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Adjunto>(entity =>
        {
            entity.HasKey(e => e.idAdjunto).HasFillFactor(90);

            entity.Property(e => e.fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AdjuntosEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Adjuntos__3214EC07FF40C398");
        });

        modelBuilder.Entity<AdjuntosEstadoFlete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Adjuntos__3214EC071D926FE5");
        });

        modelBuilder.Entity<AdjuntosExpo>(entity =>
        {
            entity.HasKey(e => e.idAdjuntoexpo)
                .HasName("PK_Adjuntosexpo")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<AdjuntosPlanvallejo>(entity =>
        {
            entity.HasKey(e => e.idAdjunto).HasName("PK__Adjuntos__8DEE30690EF836A4");
        });

        modelBuilder.Entity<Aeropuerto>(entity =>
        {
            entity.HasKey(e => e.idaeropuerto).HasFillFactor(90);
        });

        modelBuilder.Entity<Alerta>(entity =>
        {
            entity.HasKey(e => e.IdAlerta).HasFillFactor(90);
        });

        modelBuilder.Entity<AlertaComentario>(entity =>
        {
            entity.HasKey(e => e.IdComentarios).HasFillFactor(90);

            entity.Property(e => e.fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AlertasAdjunto>(entity =>
        {
            entity.HasKey(e => e.IdAdjunto).HasFillFactor(90);

            entity.Property(e => e.fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AlertasCorreosConfiguracion>(entity =>
        {
            entity.HasKey(e => e.idConfiguracion)
                .HasName("PK_AlertasConfiguracion")
                .HasFillFactor(90);

            entity.Property(e => e.ultimasincronizacion).IsFixedLength();
        });

        modelBuilder.Entity<AlertasGenerada>(entity =>
        {
            entity.HasKey(e => e.idAlertasGeneradas).HasFillFactor(90);

            entity.Property(e => e.fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AlertasRecurrente>(entity =>
        {
            entity.HasKey(e => e.IdAlertaRecurrente).HasFillFactor(90);
        });

        modelBuilder.Entity<AlertasRecurrentesDisparador>(entity =>
        {
            entity.HasKey(e => e.IdDisparar).HasFillFactor(90);
        });

        modelBuilder.Entity<Almacene>(entity =>
        {
            entity.Property(e => e.idciudad).IsFixedLength();
        });

        modelBuilder.Entity<Anticipo>(entity =>
        {
            entity.HasKey(e => e.idAnticipo).HasName("PK__Anticipo__E6633DB52FCF1A8A");

            entity.HasOne(d => d.TipoCargaNavigation).WithMany(p => p.Anticipos).HasConstraintName("FK__Anticipo__TipoCa__58A712EB");

            entity.HasOne(d => d.ViaNavigation).WithMany(p => p.Anticipos).HasConstraintName("FK__Anticipo__ModoTransporte");

            entity.HasOne(d => d.idClienteNavigation).WithMany(p => p.Anticipos).HasConstraintName("FK__Anticipo__idClie__53E25DCE");

            entity.HasOne(d => d.idMonedaNavigation).WithMany(p => p.Anticipos).HasConstraintName("FK__Anticipo__idMone__54D68207");

            entity.HasOne(d => d.idPuertoNavigation).WithMany(p => p.Anticipos).HasConstraintName("FK__Anticipo__idPuer__55CAA640");

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.Anticipos).HasConstraintName("FK__Anticipo__idUsua__56BECA79");
        });

        modelBuilder.Entity<AnticiposPendiente>(entity =>
        {
            entity.ToView("AnticiposPendientes");
        });

        modelBuilder.Entity<Arancel>(entity =>
        {
            entity.HasKey(e => e.idarancel).HasFillFactor(90);
        });

        modelBuilder.Entity<AreasLogistica>(entity =>
        {
            entity.HasKey(e => e.idarealogistica).HasFillFactor(90);
        });

        modelBuilder.Entity<ArqueoCaja>(entity =>
        {
            entity.ToView("ArqueoCaja");
        });

        modelBuilder.Entity<Aseguradora>(entity =>
        {
            entity.HasKey(e => e.idaseguradora)
                .HasName("PK_Aseguradora")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<AsignacionTransporte_Madecentro>(entity =>
        {
            entity.ToView("AsignacionTransporte_Madecentro");
        });

        modelBuilder.Entity<AsuntosCorreoEnviadoPorDO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsuntosC__3214EC075D6CF6EA");
        });

        modelBuilder.Entity<AumentoMonto>(entity =>
        {
            entity.Property(e => e.valor).IsFixedLength();
        });

        modelBuilder.Entity<AutorizacionEmbarqueReport>(entity =>
        {
            entity.ToView("AutorizacionEmbarqueReport");
        });

        modelBuilder.Entity<Autorizaciones_Impuesto>(entity =>
        {
            entity.ToView("Autorizaciones_Impuestos");
        });

        modelBuilder.Entity<Autorizaciones_Tercero>(entity =>
        {
            entity.ToView("Autorizaciones_Terceros");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.idBanco).HasName("PK__Bancos__D8FFCB75370627FE");

            entity.HasOne(d => d.idPaisNavigation).WithMany(p => p.Bancos).HasConstraintName("FK__Bancos__idPais__599B3724");
        });

        modelBuilder.Entity<BibliotecaExportacion>(entity =>
        {
            entity.Property(e => e.idBiblioteca).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CajaMenor>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__CajaMeno__3213E83F3EA749C6");
        });

        modelBuilder.Entity<CalificacionProveedore>(entity =>
        {
            entity.HasKey(e => e.idCalificacion).HasName("PK__Califica__E056358F6DB809C1");

            entity.Property(e => e.FechaCierre).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<CalificacionProveedoresDetalle>(entity =>
        {
            entity.ToView("CalificacionProveedoresDetalle");
        });

        modelBuilder.Entity<CambiosEnCatalogo>(entity =>
        {
            entity.Property(e => e.idcambio).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CaracteristicaEspecial>(entity =>
        {
            entity.HasKey(e => e.IdCaracteristica).HasName("PK__Caracter__8761175C436BFEE3");
        });

        modelBuilder.Entity<CaracteristicasxGasto>(entity =>
        {
            entity.HasKey(e => e.idCaracteristicasxGastos).HasName("PK__Caracter__D017D7DE473C8FC7");

            entity.HasOne(d => d.idCausacionNavigation).WithMany(p => p.CaracteristicasxGastos).HasConstraintName("FK__Caracteri__idCau__5A8F5B5D");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.CaracteristicasxGastos).HasConstraintName("FK__Caracteri__idGas__5B837F96");
        });

        modelBuilder.Entity<Carpeta>(entity =>
        {
            entity.HasKey(e => e.idcarpeta).HasFillFactor(90);

            entity.Property(e => e.protegido).HasDefaultValue(false);
        });

        modelBuilder.Entity<Cartera_Abiertum>(entity =>
        {
            entity.ToView("Cartera_Abierta");

            entity.Property(e => e.idfactura).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Cartera_Detalladum>(entity =>
        {
            entity.ToView("Cartera_Detallada");

            entity.Property(e => e.idfactura).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasFillFactor(90);
        });

        modelBuilder.Entity<CategoriasItem>(entity =>
        {
            entity.HasKey(e => e.idcategoriaitem).HasFillFactor(90);
        });

        modelBuilder.Entity<Causacione>(entity =>
        {
            entity.HasKey(e => e.idCausacion).HasFillFactor(90);
        });

        modelBuilder.Entity<CausalesError>(entity =>
        {
            entity.HasKey(e => e.idcausaleserror).HasFillFactor(90);
        });

        modelBuilder.Entity<Certificado>(entity =>
        {
            entity.HasKey(e => e.idcertificado).HasFillFactor(90);
        });

        modelBuilder.Entity<CheckDocumento>(entity =>
        {
            entity.HasKey(e => e.idCheckDocumentos)
                .HasName("PK__CheckDoc__F143A19D5A4F643B")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<CheckDocumentositem>(entity =>
        {
            entity.HasKey(e => e.idCheckDocumentositem)
                .HasName("PK__CheckDoc__F0139DBB5E1FF51F")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ChequeoEspesial>(entity =>
        {
            entity.HasKey(e => e.idChequeoEspesial).HasName("PK__ChequeoE__EB5EE59061F08603");

            entity.HasOne(d => d.idListaChequeoEncabezadoNavigation).WithMany(p => p.ChequeoEspesials).HasConstraintName("FK__ChequeoEs__idLis__5F54107A");

            entity.HasOne(d => d.idcaracteristicaespecialNavigation).WithMany(p => p.ChequeoEspesials).HasConstraintName("FK__ChequeoEs__idcar__5E5FEC41");
        });

        modelBuilder.Entity<CiudadesAduanimex>(entity =>
        {
            entity.HasKey(e => e.idCiudadesAduanimex).HasName("PK__Ciudades__386B78B57167D3BD");

            entity.HasOne(d => d.idLugarIngresoMercanciasNavigation).WithMany(p => p.CiudadesAduanimexes).HasConstraintName("FK__CiudadesA__idLug__604834B3");

            entity.HasOne(d => d.idPaisNavigation).WithMany(p => p.CiudadesAduanimexes).HasConstraintName("FK__CiudadesA__idPai__0055DCE9");
        });

        modelBuilder.Entity<Clasificacion2>(entity =>
        {
            entity.Property(e => e.idclasificacion).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClasificacionRiesgo>(entity =>
        {
            entity.HasKey(e => e.idClasificacionRiesgo).HasFillFactor(90);
        });

        modelBuilder.Entity<ClaveRegistrada>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClaveReg__3214EC0795B1613A");
        });

        modelBuilder.Entity<CodRegimenPrecedente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(90);
        });

        modelBuilder.Entity<CodigoEmbalaje>(entity =>
        {
            entity.HasKey(e => e.idcodigoembalaje).HasFillFactor(90);
        });

        modelBuilder.Entity<Columna>(entity =>
        {
            entity.HasKey(e => e.idcolumna).HasFillFactor(90);

            entity.Property(e => e.paginacion).HasDefaultValue(10);
        });

        modelBuilder.Entity<ColumnasAgrupacione>(entity =>
        {
            entity.HasKey(e => e.idcolumna).HasFillFactor(90);
        });

        modelBuilder.Entity<ColumnasAgrupacionesOrden>(entity =>
        {
            entity.HasKey(e => e.idcolumna).HasFillFactor(90);
        });

        modelBuilder.Entity<ColumnasExportacion>(entity =>
        {
            entity.HasKey(e => e.idcolumnasexportacion).HasFillFactor(90);

            entity.Property(e => e.nombrefiltro).IsFixedLength();
            entity.Property(e => e.nombreformulario).IsFixedLength();
            entity.Property(e => e.texto).IsFixedLength();
            entity.Property(e => e.valor).IsFixedLength();
        });

        modelBuilder.Entity<ComentarioEntregaExportacion>(entity =>
        {
            entity.HasKey(e => e.idComentario).HasFillFactor(90);
        });

        modelBuilder.Entity<ComisionesxEmpresa>(entity =>
        {
            entity.HasKey(e => e.idcomisionxempresa).HasFillFactor(90);
        });

        modelBuilder.Entity<Comisionista>(entity =>
        {
            entity.HasKey(e => e.idcomisionista).HasFillFactor(90);
        });

        modelBuilder.Entity<Compradore>(entity =>
        {
            entity.HasKey(e => e.idcomprador).HasFillFactor(90);
        });

        modelBuilder.Entity<Comunicacion>(entity =>
        {
            entity.HasKey(e => e.idcomunicacion)
                .HasName("PK_Registro1")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<Confcorreoscontenedore>(entity =>
        {
            entity.HasKey(e => e.idcorreoscontenedores).HasFillFactor(90);
        });

        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity.HasKey(e => e.idConfiguracion).HasFillFactor(90);
        });

        modelBuilder.Entity<ConfiguracionPerfile>(entity =>
        {
            entity.HasKey(e => e.idPerfilConfiguracino).HasName("PK__Configur__112F5FA409FE775D");
        });

        modelBuilder.Entity<ConsecutivoCotizacion>(entity =>
        {
            entity.Property(e => e.idConsecutivo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Consulta>(entity =>
        {
            entity.HasKey(e => e.idconsulta)
                .HasName("PK__Consulta__8CFD796615702A09")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ConsultaAsiscomex>(entity =>
        {
            entity.HasKey(e => e.idConsultaAsiscomex).HasName("PK__Consulta__F9FBC5A4119F9925");
        });

        modelBuilder.Entity<ContenedorAnticipo>(entity =>
        {
            entity.HasKey(e => e.idContenedorAnticipo).HasName("PK__Contened__0E90AF641940BAED");

            entity.HasOne(d => d.idAnticipoNavigation).WithMany(p => p.ContenedorAnticipos).HasConstraintName("FK__Contenedo__idAnt__014A0122");

            entity.HasOne(d => d.idTamanoContenedorNavigation).WithMany(p => p.ContenedorAnticipos).HasConstraintName("FK__Contenedo__idTam__023E255B");

            entity.HasOne(d => d.idTipoEquipoNavigation).WithMany(p => p.ContenedorAnticipos).HasConstraintName("FK__Contenedo__idTip__03324994");
        });

        modelBuilder.Entity<Contenedore>(entity =>
        {
            entity.HasKey(e => e.idContenedor).HasFillFactor(90);
        });

        modelBuilder.Entity<ContenedoresDevolucion>(entity =>
        {
            entity.HasKey(e => e.idDevolucion).HasFillFactor(90);
        });

        modelBuilder.Entity<ContenedoresLiquidacion>(entity =>
        {
            entity.HasKey(e => e.idLiquidacion).HasFillFactor(90);
        });

        modelBuilder.Entity<ControlCargasImportacion>(entity =>
        {
            entity.HasKey(e => e.idcontrolcargasimportacion).HasName("PK__ControlC__7D47D56122CA2527");
        });

        modelBuilder.Entity<ControlCorreo>(entity =>
        {
            entity.HasKey(e => e.IdCorreo).HasFillFactor(90);
        });

        modelBuilder.Entity<ControlDeposito>(entity =>
        {
            entity.HasKey(e => e.idcontroldeposito)
                .HasName("PK__ControlD__B7C3C6952882FE7D")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ControlDepositoDetalle>(entity =>
        {
            entity.HasKey(e => e.idcontroldepositodetalle)
                .HasName("PK__ControlD__BC1BABED2C538F61")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<CostosLogistico>(entity =>
        {
            entity.ToView("CostosLogisticos");
        });

        modelBuilder.Entity<Costos_Exportacione>(entity =>
        {
            entity.ToView("Costos_Exportaciones");
        });

        modelBuilder.Entity<Cotizacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cotizaci__3214EC07B4842D2A");

            entity.HasOne(d => d.Comercial).WithMany(p => p.Cotizaciones).HasConstraintName("FK__Cotizacio__Comer__45FF1E22");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.Cotizaciones).HasConstraintName("FK__Cotizacio__Estad__46F3425B");

            entity.HasOne(d => d.Exportador).WithMany(p => p.Cotizaciones).HasConstraintName("FK__Cotizacio__Expor__47E76694");

            entity.HasOne(d => d.Incoterm).WithMany(p => p.Cotizaciones).HasConstraintName("FK__Cotizacio__Incot__48DB8ACD");

            entity.HasOne(d => d.Modena).WithMany(p => p.Cotizaciones).HasConstraintName("FK__Cotizacio__Moden__49CFAF06");

            entity.HasOne(d => d.TipoOperacion).WithMany(p => p.Cotizaciones).HasConstraintName("FK__Cotizacio__TipoO__4AC3D33F");
        });

        modelBuilder.Entity<Cronograma>(entity =>
        {
            entity.ToView("Cronograma");

            entity.Property(e => e.fechaanticipo).IsFixedLength();
            entity.Property(e => e.fechasolanticipo).IsFixedLength();
        });

        modelBuilder.Entity<CronogramaExpo>(entity =>
        {
            entity.ToView("CronogramaExpo");
        });

        modelBuilder.Entity<Cuadro>(entity =>
        {
            entity.HasKey(e => e.idcuadro).HasFillFactor(90);
        });

        modelBuilder.Entity<CuadrosItem>(entity =>
        {
            entity.HasKey(e => e.idcuadroitem).HasFillFactor(90);
        });

        modelBuilder.Entity<CuentasxPagar>(entity =>
        {
            entity.ToView("CuentasxPagar");
        });

        modelBuilder.Entity<CuentasxPagar_Abiertum>(entity =>
        {
            entity.ToView("CuentasxPagar_Abierta");
        });

        modelBuilder.Entity<CuposAutGlobal>(entity =>
        {
            entity.HasKey(e => e.idCupoGlobal).HasFillFactor(90);
        });

        modelBuilder.Entity<DEX>(entity =>
        {
            entity.HasKey(e => e.IdDEX).HasFillFactor(90);
        });

        modelBuilder.Entity<DEXItem>(entity =>
        {
            entity.HasKey(e => e.IdDEXItem).HasFillFactor(90);
        });

        modelBuilder.Entity<DIANCIP>(entity =>
        {
            entity.HasKey(e => e.idcip).HasFillFactor(90);
        });

        modelBuilder.Entity<DO>(entity =>
        {
            entity.HasKey(e => e.idDO).HasFillFactor(90);

            entity.Property(e => e.Observaciones_Instrucciones).HasDefaultValue("");
        });

        modelBuilder.Entity<DO_Adjunto>(entity =>
        {
            entity.HasKey(e => e.idAdjunto).HasFillFactor(90);
        });

        modelBuilder.Entity<DO_Configuracion>(entity =>
        {
            entity.HasKey(e => e.idConfiguracion).HasFillFactor(90);
        });

        modelBuilder.Entity<DO_Configuracion_Expo>(entity =>
        {
            entity.HasKey(e => e.idConfiguracion).HasFillFactor(90);
        });

        modelBuilder.Entity<DatosTecnico>(entity =>
        {
            entity.HasKey(e => e.iddatotecnico).HasFillFactor(90);
        });

        modelBuilder.Entity<Datosserie>(entity =>
        {
            entity.HasKey(e => e.iddatoserie).HasFillFactor(90);
        });

        modelBuilder.Entity<DeclaracionAndinadelValor>(entity =>
        {
            entity.HasKey(e => e.iddeclaandina).HasFillFactor(90);
        });

        modelBuilder.Entity<DepartamentoDestino>(entity =>
        {
            entity.Property(e => e.iddepartamento).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Deposito>(entity =>
        {
            entity.HasKey(e => e.iddeposito).HasFillFactor(90);
        });

        modelBuilder.Entity<Depositoscontenedor>(entity =>
        {
            entity.ToView("Depositoscontenedor");
        });

        modelBuilder.Entity<DepositoscontenedorTodo>(entity =>
        {
            entity.ToView("DepositoscontenedorTodos");
        });

        modelBuilder.Entity<Despacho>(entity =>
        {
            entity.HasKey(e => e.iddespacho).HasFillFactor(90);
        });

        modelBuilder.Entity<DespachoExport>(entity =>
        {
            entity.HasKey(e => e.iddespacho).HasFillFactor(90);

            entity.Property(e => e.cantidadsolicitada).IsFixedLength();
        });

        modelBuilder.Entity<DespachosItem>(entity =>
        {
            entity.HasKey(e => e.iddespachoitem).HasFillFactor(90);
        });

        modelBuilder.Entity<DetalleArancelDO>(entity =>
        {
            entity.HasKey(e => e.idDetalleArancelDo).HasName("PK__DetalleA__ECF2DC15207893B8");
        });

        modelBuilder.Entity<DetalleContenedoresdelDO>(entity =>
        {
            entity.HasKey(e => e.idDetalleContenedoresDO).HasName("PK__DetalleC__5AEB3F5F253D48D5");
        });

        modelBuilder.Entity<DetalleImpuestosAnticipo>(entity =>
        {
            entity.HasKey(e => e.idDetalleImpuestosAnticipo).HasName("PK__DetalleI__39B6CCDA61BB7BD9");

            entity.Property(e => e.NroDO).HasDefaultValue("");
        });

        modelBuilder.Entity<DetalleInformeDinamico>(entity =>
        {
            entity.HasKey(e => e.idtabladetalleinformedinamico).HasFillFactor(90);
        });

        modelBuilder.Entity<DetalleMercanciasCotizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetalleM__3214EC078F29B647");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.DetalleMercanciasCotizacions).HasConstraintName("FK__DetalleMe__Cotiz__4BB7F778");
        });

        modelBuilder.Entity<DetalleReciboCajaAnticipo>(entity =>
        {
            entity.HasKey(e => e.idDetalleReciboCajaAnticipo).HasName("PK__DetalleR__054352742BFE89A6");

            entity.HasOne(d => d.idAnticipoNavigation).WithMany(p => p.DetalleReciboCajaAnticipos).HasConstraintName("FK__DetalleRe__idAnt__08EB22EA");

            entity.HasOne(d => d.idReciboCajaAnticipoNavigation).WithMany(p => p.DetalleReciboCajaAnticipos).HasConstraintName("FK__DetalleRe__idRec__09DF4723");
        });

        modelBuilder.Entity<DetalleReciboCajaMenor>(entity =>
        {
            entity.HasKey(e => e.idDetalleReciboCajaMenor).HasName("PK__DetalleR__C51A26A7753864A1");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.DetalleReciboCajaMenors).HasConstraintName("FK__DetalleRe__idGas__0AD36B5C");

            entity.HasOne(d => d.idReciboCajaMenorNavigation).WithMany(p => p.DetalleReciboCajaMenors).HasConstraintName("FK__DetalleRe__idRec__0BC78F95");
        });

        modelBuilder.Entity<DetalleResponsablesDO>(entity =>
        {
            entity.HasKey(e => e.idDetalleResponsablesDO).HasName("PK__DetalleR__6B3FDC0B2A01FDF2");
        });

        modelBuilder.Entity<Devolucion_Cliente>(entity =>
        {
            entity.ToView("Devolucion_Clientes");
        });

        modelBuilder.Entity<DireccionTerritorial>(entity =>
        {
            entity.HasKey(e => e.iddireccionterritorial).HasFillFactor(90);
        });

        modelBuilder.Entity<DisposicionCarga>(entity =>
        {
            entity.HasKey(e => e.iddisposicioncarga).HasFillFactor(90);
        });

        modelBuilder.Entity<DoCausalesError>(entity =>
        {
            entity.HasKey(e => e.iddocausale).HasFillFactor(90);
        });

        modelBuilder.Entity<DocTransporteExportacion>(entity =>
        {
            entity.HasKey(e => e.idDocTransporteExportacion)
                .HasName("PK__DocTrans__901AF4DD7A8729A3")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<Documento1>(entity =>
        {
            entity.HasKey(e => e.iddocumento)
                .HasName("PK_documentos")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<DocumentoTransporte>(entity =>
        {
            entity.HasKey(e => e.idBL).HasFillFactor(90);

            entity.Property(e => e.Valordia).HasDefaultValue(0m);
            entity.Property(e => e.diasLibres).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<DocumentosAdjuntosTercero>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Document__3213E83F4477B646");
        });

        modelBuilder.Entity<DocumentosAjuntosCliente>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Document__3213E83F5C21FF84");
        });

        modelBuilder.Entity<DocumentosDIAN>(entity =>
        {
            entity.HasKey(e => e.idDocumentosDian).HasName("PK__Document__A9E4610A31A31FBA");
        });

        modelBuilder.Entity<DocumentosDemora>(entity =>
        {
            entity.ToView("DocumentosDemoras");
        });

        modelBuilder.Entity<DocumentosExportacion>(entity =>
        {
            entity.Property(e => e.iddocumento).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DocumentosListaChequeo>(entity =>
        {
            entity.HasKey(e => e.idDocumentosListaChequeo).HasName("PK__Document__2BAD2DED031C6FA4");

            entity.HasOne(d => d.idDocumentoNavigation).WithMany(p => p.DocumentosListaChequeos).HasConstraintName("FK__Documento__idDoc__0CBBB3CE");

            entity.HasOne(d => d.idListaChequeoEncabezadoNavigation).WithMany(p => p.DocumentosListaChequeos).HasConstraintName("FK__Documento__idLis__0DAFD807");
        });

        modelBuilder.Entity<Documentos_Subpartidum>(entity =>
        {
            entity.HasKey(e => e.idDocumentosubpartida)
                .HasName("PK_Documento_Subpartida")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<Documentossoporte>(entity =>
        {
            entity.HasKey(e => e.iddocumento).HasFillFactor(90);
        });

        modelBuilder.Entity<Embarcadore>(entity =>
        {
            entity.HasKey(e => e.idembarcador).HasFillFactor(90);
        });

        modelBuilder.Entity<EnvioCorreoArriboMotonave>(entity =>
        {
            entity.HasKey(e => e.idenviocorreoarribomotonave)
                .HasName("PK__EnvioCor__B7D1BD1D0ABD916C")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<EnvioCorreoArriboMotonaveAduana>(entity =>
        {
            entity.HasKey(e => e.idenvioaduana).HasFillFactor(90);
        });

        modelBuilder.Entity<EnvioCorreoArriboMotonaveDetalle>(entity =>
        {
            entity.HasKey(e => e.idenvioCorreoarribomotonavedetalle)
                .HasName("PK__EnvioCor__7FE90AC310766AC2")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ErroresImpo>(entity =>
        {
            entity.HasKey(e => e.iderroresimpo)
                .HasName("PK__ErroresI__33F324801446FBA6")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<EstadoContenedore>(entity =>
        {
            entity.HasKey(e => e.idestadocontenedor).HasFillFactor(90);
        });

        modelBuilder.Entity<EstadoCotizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoCo__3214EC07DF416870");
        });

        modelBuilder.Entity<EstadoElimiadoPorDO>(entity =>
        {
            entity.HasKey(e => e.idEstadoEliminado).HasName("PK__EstadoEl__2D3BBE8A3667D4D7");
        });

        modelBuilder.Entity<EstadoLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoLo__3214EC071FFAA527");

            entity.Property(e => e.Destinatario).HasDefaultValue("");
        });

        modelBuilder.Entity<EstadoNegociosHaceb>(entity =>
        {
            entity.ToView("EstadoNegociosHaceb");
        });

        modelBuilder.Entity<EstadosDo>(entity =>
        {
            entity.ToView("EstadosDo");
        });

        modelBuilder.Entity<EstadosMercancium>(entity =>
        {
            entity.HasKey(e => e.idestado).HasFillFactor(90);
        });

        modelBuilder.Entity<EstructuraBorradorSAE>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(90);
        });

        modelBuilder.Entity<EstructuraW>(entity =>
        {
            entity.HasKey(e => e.idws).HasFillFactor(90);
        });

        modelBuilder.Entity<EstructuraWSIR>(entity =>
        {
            entity.HasKey(e => e.idestructuraWSRI).HasFillFactor(90);
        });

        modelBuilder.Entity<EventoEstadoExportacione>(entity =>
        {
            entity.HasKey(e => e.idEventoEstado).HasFillFactor(90);
        });

        modelBuilder.Entity<EventosAlerta>(entity =>
        {
            entity.HasKey(e => e.idEvento).HasFillFactor(90);
        });

        modelBuilder.Entity<ExcepcionesImpo>(entity =>
        {
            entity.HasKey(e => e.idExcepcion).HasName("PK__Excepcio__E1BD57AF2B2A60FE");
        });

        modelBuilder.Entity<F560_2009_Frente>(entity =>
        {
            entity.HasKey(e => e.id).HasFillFactor(90);

            entity.Property(e => e.id).HasComment("Número unico que identifica al registro dentro de la tabla");
            entity.Property(e => e.DG_CodigoCondicionVendedor).HasComment("Código de la condición del vendedor, que hace referencia a la forma como actúa, de acuerdo a la siguiente clasificación: 1. Fabricante. 2. Distribuidor (Dealer). 3. Otro.");
            entity.Property(e => e.DG_CodigoFormaEnvio).HasComment("Indica si la mercancía declarada corresponde a un envío\r\núnico o fraccionado y/o a un valor total o fraccionado, de acuerdo con la siguiente\r\ncodificación:	\r\n1.	 Envío único o total y valor total.	\r\n2. 	 Envío único o total y valor fraccionado.	\r\n3. 	 Envío fraccionado y valor total.	\r\n4. 	 Envío fraccionado y valor fraccionado.");
            entity.Property(e => e.DG_CodigoMoneda1).HasComment("Indica el código de la moneda en la que se realizó la negociación de la mercancía, según factura comercial o documento que refleje la negociación.");
            entity.Property(e => e.DG_CodigoMoneda2).HasComment("Indica el código de la moneda en la que se realizó la negociación de la mercancía, según factura comercial o documento que refleje la negociación.");
            entity.Property(e => e.DG_CodigoMoneda3).HasComment("Indica el código de la moneda en la que se realizó la negociación de la mercancía, según factura comercial o documento que refleje la negociación.");
            entity.Property(e => e.DG_CodigoNaturalezaTransaccion).HasComment("Indica el código que mejor refleje las\r\ncondiciones en las que se efectuó la negociación, se adquirió la mercancía o la razón\r\npor la que se realiza la importación, según la siguiente tabla:\r\n11.	 Compraventa a precio firme para exportación a Colombia.\r\n12.	 Compraventa a precio revisable para exportación a Colombia.\r\n13.	 Compraventa para uso en el exterior y posterior exportación.\r\n14.	 Suministros gratuitos (Regalos, muestras, material publicitario).\r\n15.	 Reparación o transformación.\r\n16.	 Importación de mercancías efectuada por sucursales, provenientes directa o\r\nindirectamente de su casa principal.\r\n17.	 Entrega bajo consignación, para la venta a la vista o a prueba.\r\n18.	 Intercambio compensado.\r\n19.	 Arrendamiento financiero (Alquiler con opción de compra o leasing).\r\n20.	 Alquiler simple, arrendamiento operativo.\r\n21.	 Sustitución de mercancías devueltas.\r\n22.	 Sustitución de mercancías no devueltas (Bajo garantía).\r\n23. 	 Mercancías suministradas en el marco de programas de ayuda, promovidos o\r\nfinanciados total o parcialmente por la Comunidad Andina.\r\n24.	 Otras ayudas gubernamentales.\r\n25.	 Otras ayudas (Privadas, organizaciones no gubernamentales).\r\n26.	 Operaciones en el marco de programas intergubernamentales de fabricación\r\nconjunta.\r\n27.	 Suministros parciales de materiales y/o maquinaria en el marco de un contrato\r\ngeneral de construcción (envíos parciales)\r\n28.	 Préstamo, comodato.\r\n29.	 Otras transacciones (Especifique).\r\nCuando la negociación corresponda a códigos diferentes a 11 ó 12, no podrá valorarse\r\ncon el Método del Valor de Transacción; en consecuencia, no se diligenciarán las\r\ncasillas 56 a 66 y 78 a 136. Si la negociación es una compraventa pero no cumple\r\ncon todos los requisitos para valorar con el primer método se diligencian las casillas\r\n1 a 92.");
            entity.Property(e => e.DG_CodigoNivelComercialComprador).HasComment("Código de la posición comercial del comprador en el mercado nacional de acuerdo a la siguiente clasificación: 1. Mayorista. 2. Minorista. 3. Usuario final. 4. Otro.");
            entity.Property(e => e.DG_CodigoPaisProcedencia).HasComment("Indica el código del país en donde se embarcó la mercancía para su exportación a Colombia.");
            entity.Property(e => e.DG_CodigoSeccional).HasComment("Código de la dirección seccioinal de aduanas");
            entity.Property(e => e.DG_CodigoTipoResolucion).HasComment("Concepto por el cual se expidió la resolución conforme a lo siguiente: 1. Ajuste de valor permanente. 2. Declaración simplificada.");
            entity.Property(e => e.DG_CondicionEntrega).HasComment("Indica las condiciones de entrega según\r\nlos códigos que se relacionan a continuación:\r\nEXW	 En fábrica\r\nFCA 	 Franco transportista\r\nFAS 	 Franco al costado del buque\r\nFOB 	 Franco a bordo\r\nCFR 	 Coste y flete\r\nCIF 	 Coste, seguro y flete\r\nCPT 	 Coste y flete\r\nCIP 	 Coste, seguro y flete\r\nDAF 	 Lugar de entrega convenido en la frontera\r\nDES 	 Entregada sobre buque\r\nDEQ 	 Franco sobre muelle\r\nDDU	 Entregada con derechos no pagados\r\nDDP 	 Entregada con derechos pagados	\r\nEn caso de negociar en una condición de entrega diferente a las anteriores, indique\r\nla que corresponda.");
            entity.Property(e => e.DG_ContratoFecha)
                .HasDefaultValue("")
                .HasComment("Año mes y día correspondiente a la fecha del contrato u otro documento");
            entity.Property(e => e.DG_ContratoNumero)
                .HasDefaultValue("")
                .HasComment("Número del contrato o documento indicado en la casilla 42, en caso de existir.");
            entity.Property(e => e.DG_ContratoTipo)
                .HasDefaultValue("")
                .HasComment("Si existe contrato o documento que registre o de cuenta de la transacción y los términos de la negociación, indíquelo.\r\nPor ejemplo:\r\nCompraventa (Verbal o escrito), leasing, arrendamiento simple, etc..");
            entity.Property(e => e.DG_ContratoValor).HasComment("Es el valor total del contrato o documento citado en la moneda y términos de negociación.");
            entity.Property(e => e.DG_Especifique_CCV)
                .HasDefaultValue("")
                .HasComment("Indique la condición del vendedor en el caso en que en la casilla 30 se haya respondido el código 3, \"Otro\".");
            entity.Property(e => e.DG_Especifique_CNCC)
                .HasDefaultValue("")
                .HasComment("Indique el nivel comercial del comprador en el caso en que en la casilla 28 se haya consignado el código 4 \"Otro\".");
            entity.Property(e => e.DG_FacturaFecha).HasComment("Registro del año, mes y día en que fue expedida la factura");
            entity.Property(e => e.DG_FacturaNumero).HasComment("Indica el número de la factura comercial expedida por el vendedor o proveedor, como soporte de la negociación y que contiene los pagos efectuados o por efectuar por el comprador al vendedor.");
            entity.Property(e => e.DG_FechaDeclaraciónImp).HasComment("Fecha de presentación y aceptación registrada en la declaración de importación");
            entity.Property(e => e.DG_FechaTipoCambio1)
                .HasDefaultValue("''")
                .HasComment("Corresponde a la fecha del tipo de cambio utilizado");
            entity.Property(e => e.DG_FechaTipoCambio2)
                .HasDefaultValue("''")
                .HasComment("Corresponde a la fecha del tipo de cambio utilizado");
            entity.Property(e => e.DG_FechaTipoCambio3)
                .HasDefaultValue("''")
                .HasComment("Corresponde a la fecha del tipo de cambio utilizado");
            entity.Property(e => e.DG_Lugar).HasComment("Indica el nombre del sitio, lugar, puerto o aeropuerto, pactado para la entrega de las mercancías.");
            entity.Property(e => e.DG_NumeroDeclarcionImp).HasComment("Número de aceptación asignado a la declaración de importación");
            entity.Property(e => e.DG_ResolucionFecha).HasComment("Año, mes y día en que fue expedida la resolución");
            entity.Property(e => e.DG_ResolucionNumero).HasComment("Número de la resolución expedida por la autoridad aduanera");
            entity.Property(e => e.DG_TipoDeclaracionImp).HasComment("Código del tipo de declaración de importación así: 1. Inicial 2. Legalización 3. Anticipada 4. Correción 5. Modificación");
            entity.Property(e => e.DG_ValorFOB).HasComment("Registre en la moneda de negociación el valor total de la transacción en términos FOB Si la negociación se cumplió en un término diferente a éste, realice los ajustes a que haya lugar para llevarlo a FOB.");
            entity.Property(e => e.IM_Ciudad)
                .HasDefaultValue("")
                .HasComment("Nombre de la localidad o lugar donde se encuentra domiciliado el intermediario.");
            entity.Property(e => e.IM_CodigoPais)
                .HasDefaultValue("")
                .HasComment("Código del país correspondiente a la ciudad del domicilio del intermediario.");
            entity.Property(e => e.IM_CodigoTipoIntermediario)
                .HasDefaultValue("")
                .HasComment("Si la respuesta es afirmativa, señale la clase de intermediación utilizando los códigos de la tabla siguiente:\r\n1. Agente de venta.\r\n2. Agente de compra.\r\n3. Corredor (Broker).\r\n4. Otros tipos de intermediación.");
            entity.Property(e => e.IM_Direccion).HasComment("Dirección domiciliaria del intermediario.");
            entity.Property(e => e.IM_Especifique)
                .HasDefaultValue("")
                .HasComment("Sí en la casilla anterior consignó el código correspondiente a “Otros tipos de intermediación”, indique cuál.");
            entity.Property(e => e.IM_ExisteIntermediación)
                .HasDefaultValue("")
                .HasComment("Indica si la transacción se realizó con participación de algún intermediario denominado también agente, comisionista u otro.\r\nConsignar “S” si la respuesta es afirmativa o “N” si es negativa.");
            entity.Property(e => e.IM_OtrosNombres).HasComment("En caso de tener nombres compuestos registre los demás nombres.");
            entity.Property(e => e.IM_PrimerApellido).HasComment("Registre el primer apellido del intermediario.");
            entity.Property(e => e.IM_PrimerNombre).HasComment("Registre el primer nombre del intermediario.");
            entity.Property(e => e.IM_RazonSocial).HasComment("Razón social del intermediario.");
            entity.Property(e => e.IM_SegundoApellido).HasComment("Registre el segundo apellido del intermediario.");
            entity.Property(e => e.ImportadorDV).HasComment("Digito de verificación del NIT del importador");
            entity.Property(e => e.ImportadorNIT).HasComment("Numero de identificación tributaria del importador");
            entity.Property(e => e.ImportadorOtrosNombres).HasComment("Los demas nombre compuestos del importador");
            entity.Property(e => e.ImportadorPrimerApellido).HasComment("Primer apellido del importador");
            entity.Property(e => e.ImportadorPrimerNombre).HasComment("Primer nombre del importador");
            entity.Property(e => e.ImportadorRazonSocial).HasComment("Nombre de la razón social del importador tal como este registrada en el RUT");
            entity.Property(e => e.ImportadorSegundoApellido).HasComment("Segundo apellido del importador");
            entity.Property(e => e.RQ_CodigoTipoCondicion)
                .HasDefaultValue("")
                .HasComment("código del tipo de condición o contraprestación según la tabla contenida en la descripción de la casilla 82 de la DAV en la cartilla de instrucciones de la Declaración de Importación y Andina del Valor");
            entity.Property(e => e.RQ_CodigoTipoRestricción)
                .HasDefaultValue("")
                .HasComment("Código que identifica el tipo de restricción pactado en la negociación de la mercancía importada.\r\nCód	 Restricción\r\n01	 Impuestas o exigidas por la ley o las autoridades colombianas.\r\n02	 Limitan el territorio geográfico donde puedan revenderse las mercancías.\r\n03	 No afectan sustancialmente el valor de las mercancías.\r\n04	 Otro tipo de restricciones.");
            entity.Property(e => e.RQ_CodigoTipoVinculación).HasComment("Registre el código que corresponda según una de las siguientes situaciones:\r\n1. Si una de estas personas ocupa cargos de responsabilidad o dirección en una empresa de la otra;\r\n2. Si están legalmente reconocidas como asociadas en negocios;\r\n3. Si están en relación de empleador y empleado;\r\n4. Si una persona tiene directa o indirectamente la propiedad, el control o la posesión del 5% o más de las acciones o títulos en circulación y con derecho a voto;\r\n5. Si una de ellas controla directa o indirectamente a la otra;\r\n6. Si ambas personas están controladas directa o indirectamente por una tercera;\r\n7. Si juntas controlan directa o indirectamente a una tercera persona; ú,\r\n8. Si son marido y mujer, hijos, padres, hermanos, nietos, abuelos, tío o tía y sobrino o sobrina, suegros y yerno o nuera, cuñados y cuñadas.");
            entity.Property(e => e.RQ_DeclaracionImportacionFecha)
                .HasDefaultValue("")
                .HasComment("Indica la fecha de la declaración de importación citada en la casilla anterior.");
            entity.Property(e => e.RQ_DeclaracionImportacionNumero)
                .HasDefaultValue("")
                .HasComment("Registre el número de aceptación de la declaración de importación que refleja el valor criterio.");
            entity.Property(e => e.RQ_Especifique)
                .HasDefaultValue("")
                .HasComment("Si en la casilla anterior registró el código 09 Otro tipo de condiciones");
            entity.Property(e => e.RQ_ExisteVinculacion).HasComment("Consigne “S” si existe vinculación entre el comprador y el vendedor y “N” en caso contrario.");
            entity.Property(e => e.RQ_ExistenCanones).HasComment("Registre “S” si el comprador debe pagar directa o indirectamente a su vendedor un canon (Regalía) por el derecho de utilizar un procedimiento industrial patentado y/o una marca extranjera de fábrica o de comercio. Es preciso que esta obligación se haya establecido como condición de venta y esté relacionada con las mercancías importadas. En caso positivo indique su importe en la casilla 110 y/o 111 dependiendo de la moneda de facturación.");
            entity.Property(e => e.RQ_ExistenCondiciones)
                .HasDefaultValue("")
                .HasComment("Registre “S” si la venta o el precio de la mercancía dependen de alguna exigencia especial impuesta por el vendedor; por ejemplo, asumir obligaciones adicionales en relación con la forma pago del precio de la mercancía (Regalías, repartos de beneficios, pagos indirectos, pagos anticipados), obligaciones adicionales (Compra de la mercancía y otra) o aquellas que resultan de obligaciones recíprocas (Relacionadas con la producción o comercialización de la mercancía). En caso contrario, registre “N”.");
            entity.Property(e => e.RQ_ExistenRestricciones)
                .HasDefaultValue("")
                .HasComment("Indica si existen restricciones para la cesión o utilización de las mercancías por el comprador después de su importación, de conformidad con lo señalado en el artículo 10 del Reglamento Comunitario, adoptado por la Resolución Andina 846. Responda afirmativamente registrando una “S” cuando existan limitaciones para la cesión o utilización de las mercancías, como por ejemplo: Prohibición de vender las mercancías: exigencia de utilizarlas sólo como muestra o con fines publicitarios. En caso contrario registre “N”.");
            entity.Property(e => e.RQ_ExistenReversiones).HasComment("Indique “S” si existe un pacto según el cual el comprador está obligado a revertir al vendedor, directa o indirectamente, parte del producto de la reventa, cesión o utilización posterior de las mercancías. En caso contrario registre “N”. Si la respuesta es afirmativa, indique su importe en la casilla 112 si la moneda de facturación es diferente al dólar o 113 si está negociada en esta moneda.");
            entity.Property(e => e.RQ_ExistenValoresCriterio)
                .HasDefaultValue("")
                .HasComment("Si la respuesta en la casilla anterior es “N” y conoce la existencia de valores criterio puede optar por contestar esta pregunta, que aunque es potestativa el aporte de la información permitirá decidir sobre la determinación del valor en aduana por el primer método de valoración (Art.15, del Reglamento Comunitario). Nota: Si decide no responder esta casilla anúlela con un guión, en cuyo caso las casillas 91 y 92 deberán ser también anuladas.");
            entity.Property(e => e.RQ_InfluyeVinculacionPrecioMercancia)
                .HasDefaultValue("")
                .HasComment("Consigne “S” si la vinculación influyó en el precio de las mercancías y “N” en caso contrario.");
            entity.Property(e => e.RQ_PuedeDeterminarseElValorCondicion)
                .HasDefaultValue("")
                .HasComment("Indica si puede determinarse el importe de las prestaciones o contraprestaciones, registrando “S” si puede determinarse o “N” en caso contrario. Si la respuesta es afirmativa y éstas correspondan a pagos indirectos o condiciones o contraprestaciones diferentes a cánones y reversiones, registre el importe en la casilla 95 si la moneda de facturación  es diferente al dólar o en la casilla 96 si está negociada en esta moneda");
            entity.Property(e => e.SN_DV)
                .HasDefaultValue("")
                .HasComment("Escriba el número que en el NIT se encuentra separado llamado “Dígito de Verificación” (DV).");
            entity.Property(e => e.SN_NIT)
                .HasDefaultValue("")
                .HasComment("Escriba el Número de Identificación Tributaria, sin el dígito de verificación, asignado por la DIAN a quien firma la declaración 	\r\ny está obligado a tenerlo. ");
            entity.Property(e => e.SN_OtrosNombres)
                .HasDefaultValue("")
                .HasComment("En caso de tener nombres compuestos registre los demás.");
            entity.Property(e => e.SN_PrimerApellido).HasComment("Registre el primer apellido de quien firma la declaración");
            entity.Property(e => e.SN_PrimerNombre)
                .HasDefaultValue("")
                .HasComment("Registre el primer nombre de quien firma la declaración.");
            entity.Property(e => e.SN_SegundoApellido)
                .HasDefaultValue("")
                .HasComment("Registre el segundo apellido de quien firma la declaración.");
            entity.Property(e => e.VA_CanonesDerechosLicencia)
                .HasDefaultValue(0m)
                .HasComment("Si contestó afirmativamente la casilla 85, registre el importe de los cánones o derechos de licencia. Si este valor es estimado indíquelo en la casilla 136.");
            entity.Property(e => e.VA_CanonesDerechosLicenciaUSD)
                .HasDefaultValue(0m)
                .HasComment("Si contestó afirmativamente la casilla 85, registre el importe de los cánones o derechos de licencia. Si este valor es estimado indíquelo en la casilla 136.");
            entity.Property(e => e.VA_ComisionesCorretajes)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de las comisiones de venta, pagadas por el comprador al agente o representante del vendedor extranjero y/o los gastos de corretaje, siempre que no estén incluidas en el precio pagado o por pagar por las mercancías importadas. Si este valor es estimado indíquelo en la casilla 136.");
            entity.Property(e => e.VA_ComisionesCorretajesUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de las comisiones de venta, pagadas por el comprador al agente o representante del vendedor extranjero y/o los gastos de corretaje, siempre que no estén incluidas en el precio pagado o por pagar por las mercancías importadas. Si este valor es estimado indíquelo en la casilla 136.");
            entity.Property(e => e.VA_DerechosAduanaOtrosImpuestos)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los derechos e impuestos causados con la importación, en el caso de haber negociado la mercancía con una condición de entrega según la cual el precio incluye en su totalidad o en parte los tributos aduaneros.");
            entity.Property(e => e.VA_DerechosAduanaOtrosImpuestosUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los derechos e impuestos causados con la importación, en el caso de haber negociado la mercancía con una condición de entrega según la cual el precio incluye en su totalidad o en parte los tributos aduaneros.");
            entity.Property(e => e.VA_EnvasesEmbalajes)
                .HasDefaultValue(0m)
                .HasComment("Indica el valor pagado por los continentes interiores (envases) y exteriores (embalajes) destinados a preparar las mercancías para su transporte. Incorpora el valor pagado por concepto de los recipientes que la contienen de manera definitiva o temporal; el material utilizado, la mano de obra empleada y demás gastos necesarios para efectuar dichas operaciones, siempre que tales valores no estén incluidos en el precio facturado por dichas mercancías.");
            entity.Property(e => e.VA_EnvasesEmbalajesUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el valor pagado por los continentes interiores (envases) y exteriores (embalajes) destinados a preparar las mercancías para su transporte. Incorpora el valor pagado por concepto de los recipientes que la contienen de manera definitiva o temporal; el material utilizado, la mano de obra empleada y demás gastos necesarios para efectuar dichas operaciones, siempre que tales valores no estén incluidos en el precio facturado por dichas mercancías.");
            entity.Property(e => e.VA_GastosCargaDescargaManipulación)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los gastos de carga, descarga y manipulación pagados y necesarios para colocar o retirar la mercancía del medio de transporte. Los gastos ocasionados por estos servicios, que\r\nhayan sido prestados en el lugar de importación y no figuren en el documento de transporte o en la factura no se registrarán en esta casilla.");
            entity.Property(e => e.VA_GastosCargaDescargaManipulaciónUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los gastos de carga, descarga y manipulación pagados y necesarios para colocar o retirar la mercancía del medio de transporte. Los gastos ocasionados por estos servicios, que\r\nhayan sido prestados en el lugar de importación y no figuren en el documento de transporte o en la factura no se registrarán en esta casilla.");
            entity.Property(e => e.VA_GastosConstruccionArmadoInstalacionMontajeMantenimiento)
                .HasDefaultValue(0m)
                .HasComment("Indique los gastos realizados después de la importación en relación con construcción, armado, instalación, montaje, mantenimiento y asistencia técnica de las mercancías importadas. Este rubro deberá tomarse en cuenta, entre otros casos, cuando se trate de maquinarias o equipos industriales.");
            entity.Property(e => e.VA_GastosConstruccionArmadoInstalacionMontajeMantenimientoUSD)
                .HasDefaultValue(0m)
                .HasComment("Indique los gastos realizados después de la importación en relación con construcción, armado, instalación, montaje, mantenimiento y asistencia técnica de las mercancías importadas. Este rubro deberá tomarse en cuenta, entre otros casos, cuando se trate de maquinarias o equipos industriales.");
            entity.Property(e => e.VA_GastosEntregaPosterioresIimportacion)
                .HasDefaultValue(0m)
                .HasComment("Indica los gastos de entrega de las mercancías que se ocasionen después del lugar de importación.");
            entity.Property(e => e.VA_GastosEntregaPosterioresIimportacionUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica los gastos de entrega de las mercancías que se ocasionen después del lugar de importación.");
            entity.Property(e => e.VA_GastosTransporteDesdeElLugarEmbarque)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los fletes y de otros gastos pagados relacionados con el traslado de la mercancía desde el lugar de embarque hasta el lugar de importación, o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.");
            entity.Property(e => e.VA_GastosTransporteDesdeElLugarEmbarqueUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los fletes y de otros gastos pagados relacionados con el traslado de la mercancía desde el lugar de embarque hasta el lugar de importación, o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.");
            entity.Property(e => e.VA_GastosTransporteManejoEntregaExterior)
                .HasDefaultValue(0m)
                .HasComment("Indique el importe correspondiente a los gastos en que incurrió o que fueron certificados de acuerdo con las tarifas normalmente aplicables, ocasionados por el traslado, manejo y entrega de la mercancía desde el lugar de entrega en el exterior hasta el lugar de embarque.");
            entity.Property(e => e.VA_GastosTransporteManejoEntregaExteriorUSD)
                .HasDefaultValue(0m)
                .HasComment("Indique el importe correspondiente a los gastos en que incurrió o que fueron certificados de acuerdo con las tarifas normalmente aplicables, ocasionados por el traslado, manejo y entrega de la mercancía desde el lugar de entrega en el exterior hasta el lugar de embarque.");
            entity.Property(e => e.VA_Intereses)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los intereses que deben ser pagados, en virtud de un acuerdo de financiación concertado por el importador con el proveedor, relativos a la compra de las mercancías importadas siempre que se distingan del precio de la mercancía, estén incluidos en el precio pagado o por pagar por ellas y el tipo de interés reclamado no exceda del nivel aplicado a este tipo de transacciones en Colombia.");
            entity.Property(e => e.VA_InteresesUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los intereses que deben ser pagados, en virtud de un acuerdo de financiación concertado por el importador con el proveedor, relativos a la compra de las mercancías importadas siempre que se distingan del precio de la mercancía, estén incluidos en el precio pagado o por pagar por ellas y el tipo de interés reclamado no exceda del nivel aplicado a este tipo de transacciones en Colombia.");
            entity.Property(e => e.VA_LugarImportacion)
                .HasDefaultValue("")
                .HasComment("En las casillas contiguas al número 20 preimpreso, indique\r\nel código del lugar de importación, entendiéndose como tal la primera Dirección Seccional de Aduanas, Impuestos y Aduanas o Delegada del territorio nacional en la que la mercancía deba ser sometida a las primeras formalidades aduaneras. El código será tomado de los registrados en las tablas ubicadas al final de la cartilla Declaración de Importación y Andina del Valor.");
            entity.Property(e => e.VA_OtrosGastos)
                .HasDefaultValue(0m)
                .HasComment("Indique el importe de otros gastos que conforme a las normas de valoración no se consideran parte del valor en aduana y que se encuentren incluidos en el precio pagado o por pagar. (Artículo 31 del Reglamento Comunitario).");
            entity.Property(e => e.VA_OtrosGastosUSD)
                .HasDefaultValue(0m)
                .HasComment("Indique el importe de otros gastos que conforme a las normas de valoración no se consideran parte del valor en aduana y que se encuentren incluidos en el precio pagado o por pagar. (Artículo 31 del Reglamento Comunitario).");
            entity.Property(e => e.VA_PagosIndirectosDescuentosRetroactivosUOtros)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los pagos indirectos, descuentos retroactivos, descuentos que no cumplan los requisitos señalados en la norma o los pagos anticipados que no figuran en la factura comercial.");
            entity.Property(e => e.VA_PagosIndirectosDescuentosRetroactivosUOtrosUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe de los pagos indirectos, descuentos retroactivos, descuentos que no cumplan los requisitos señalados en la norma o los pagos anticipados que no figuran en la factura comercial.");
            entity.Property(e => e.VA_PrecioNetoSegunFactura)
                .HasDefaultValue(0m)
                .HasComment("Indique el importe neto, en la moneda de negociación,para la mercancía a declarar, que aparece en la factura comercial o documento que haga sus veces, expresado en el término de entrega en que se ha efectuado la transacción según la casilla 37. Si la declaración corresponde a parte de la mercancía que ampara la factura, y ha sufrido un descuento, el precio neto por la  cantidad que se declara debe incluir el valor de los descuentos que proporcionalmente correspondan.");
            entity.Property(e => e.VA_PrecioNetoSegunFacturaUSD)
                .HasDefaultValue(0m)
                .HasComment("Indique el importe neto, en la moneda de negociación,para la mercancía a declarar, que aparece en la factura comercial o documento que haga sus veces, expresado en el término de entrega en que se ha efectuado la transacción según la casilla 37. Si la declaración corresponde a parte de la mercancía que ampara la factura, y ha sufrido un descuento, el precio neto por la  cantidad que se declara debe incluir el valor de los descuentos que proporcionalmente correspondan.");
            entity.Property(e => e.VA_PrecioPagadoOPorPagarUSD)
                .HasDefaultValue(0m)
                .HasComment("Corresponde a la sumatoria de las casillas 94 y 96");
            entity.Property(e => e.VA_PrestacionesHerramientasMatricesMoldes)
                .HasDefaultValue(0m)
                .HasComment("Indica el valor de las herramientas, matrices, moldes y elementos análogos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.");
            entity.Property(e => e.VA_PrestacionesHerramientasMatricesMoldesUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el valor de las herramientas, matrices, moldes y elementos análogos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.");
            entity.Property(e => e.VA_PrestacionesIinsumos)
                .HasDefaultValue(0m)
                .HasComment("Indique el valor de los materiales e insumos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar. Estos materiales se consumen en la producción.");
            entity.Property(e => e.VA_PrestacionesIinsumosUSD)
                .HasDefaultValue(0m)
                .HasComment("Indique el valor de los materiales e insumos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar. Estos materiales se consumen en la producción.");
            entity.Property(e => e.VA_PrestacionesIngenieriaCreacionPlanos)
                .HasDefaultValue(0m)
                .HasComment("Indica el valor de los trabajos de ingeniería, creación y perfeccionamiento, planos, diseños, croquis y otros que se realicen fuera del país de importación y necesarios para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.");
            entity.Property(e => e.VA_PrestacionesIngenieriaCreacionPlanosUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el valor de los trabajos de ingeniería, creación y perfeccionamiento, planos, diseños, croquis y otros que se realicen fuera del país de importación y necesarios para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.");
            entity.Property(e => e.VA_PrestacionesMateriasPrimas)
                .HasDefaultValue(0m)
                .HasComment("Indique el valor de los materiales, piezas y elementos, partes y artículos análogos incorporados a las mercancías importadas, suministradas directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.");
            entity.Property(e => e.VA_PrestacionesMateriasPrimasUSD)
                .HasDefaultValue(0m)
                .HasComment("Indique el valor de los materiales, piezas y elementos, partes y artículos análogos incorporados a las mercancías importadas, suministradas directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.");
            entity.Property(e => e.VA_ProductoReventaCesionUtilización)
                .HasDefaultValue(0m)
                .HasComment("Si contestó afirmativamente la casilla 86, registre el importe de la parte que revierte al proveedor extranjero como producto de\r\nla reventa, cesión o utilización de la mercancía. Si este valor es estimado indíquelo en la casilla 136.");
            entity.Property(e => e.VA_ProductoReventaCesionUtilizaciónUSD)
                .HasDefaultValue(0m)
                .HasComment("Si contestó afirmativamente la casilla 86, registre el importe de la parte que revierte al proveedor extranjero como producto de\r\nla reventa, cesión o utilización de la mercancía. Si este valor es estimado indíquelo en la casilla 136.");
            entity.Property(e => e.VA_Seguro)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe correspondiente al costo de seguro, desde el lugar de entrega de la mercancía hasta el puerto o lugar de importación de acuerdo con los documentos soporte o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.");
            entity.Property(e => e.VA_SeguroUSD)
                .HasDefaultValue(0m)
                .HasComment("Indica el importe correspondiente al costo de seguro, desde el lugar de entrega de la mercancía hasta el puerto o lugar de importación de acuerdo con los documentos soporte o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.");
            entity.Property(e => e.VA_TieneCaracterProvisional)
                .HasDefaultValue("")
                .HasComment("Indica “S” si en la presente Declaración, el importe consignado por Comisiones, \"Cánones y derechos de licencia\" o por cualquier producto de la reventa, cesión o utilización posterior de las mercancías que revierten directa o indirectamente al vendedor extranjero es provisional en caso contrario registre “N”.");
            entity.Property(e => e.VA_TotalAdiciones)
                .HasDefaultValue(0m)
                .HasComment("Corresponde a la sumatoria de los valores registrados en las casillas 99 a 122, columna \"USD\".");
            entity.Property(e => e.VA_TotalDeducciones)
                .HasDefaultValue(0m)
                .HasComment("Corresponde a la sumatoria de los valores registrados en las casillas 125 a 133, columna \"USD\".");
            entity.Property(e => e.VA_ValorTransaccionDeclarado)
                .HasDefaultValue(0m)
                .HasComment("Es el valor en aduana que declara el importador y que constituye la base gravable de las mercancías importadas.\r\nSe calcula de la siguiente manera:\r\nValor de transacción declarado = Precio Pagado o por Pagar (97) + Adiciones (123) - Deducciones (134)");
            entity.Property(e => e.anno).HasComment("Año de presentación del documento");
            entity.Property(e => e.numeroFormulario).HasComment("Número unico asignado por el sistema");
        });

        modelBuilder.Entity<Fact_Cronograma>(entity =>
        {
            entity.ToView("Fact_Cronograma");

            entity.Property(e => e.IDDO).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Fact_PendientexFacturarExpo>(entity =>
        {
            entity.ToView("Fact_PendientexFacturarExpo");

            entity.Property(e => e.Anticipos).IsFixedLength();
        });

        modelBuilder.Entity<Fact_PendientexFacturarImpo>(entity =>
        {
            entity.ToView("Fact_PendientexFacturarImpo");

            entity.Property(e => e.Anticipos).IsFixedLength();
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.idfactura).HasName("PK_Faturas");
        });

        modelBuilder.Entity<FacturaExpoItem>(entity =>
        {
            entity.HasKey(e => e.idfacturaexpoitem).HasFillFactor(90);
        });

        modelBuilder.Entity<FacturaImportacion>(entity =>
        {
            entity.HasKey(e => e.idfacturaimportacion).HasFillFactor(90);

            entity.Property(e => e.DocumentoOperativo).IsFixedLength();
        });

        modelBuilder.Entity<FacturaReciboCaja>(entity =>
        {
            entity.HasKey(e => e.idFacturaReciboCaja).HasName("PK__FacturaR__9F86168D2645B050");

            entity.HasOne(d => d.idFacturaNavigation).WithMany(p => p.FacturaReciboCajas).HasConstraintName("FK__FacturaRe__idFac__0EA3FC40");

            entity.HasOne(d => d.idReciboCajaAnticipoNavigation).WithMany(p => p.FacturaReciboCajas).HasConstraintName("FK__FacturaRe__idRec__0F982079");
        });

        modelBuilder.Entity<FacturasExpo>(entity =>
        {
            entity.HasKey(e => e.idfacturaexpo).HasFillFactor(90);

            entity.Property(e => e.idcertificado).HasDefaultValue(0);
        });

        modelBuilder.Entity<FacturasExpoItem>(entity =>
        {
            entity.HasKey(e => e.idfacturaexpoitem).HasFillFactor(90);
        });

        modelBuilder.Entity<FacturasTotale>(entity =>
        {
            entity.ToView("FacturasTotales");

            entity.Property(e => e.Fecha_Creacion).IsFixedLength();
            entity.Property(e => e.Ult__Modificacion).IsFixedLength();
        });

        modelBuilder.Entity<FacturasTotalesControl>(entity =>
        {
            entity.ToView("FacturasTotalesControl");
        });

        modelBuilder.Entity<Filtro>(entity =>
        {
            entity.HasKey(e => e.idconsulta).HasFillFactor(90);
        });

        modelBuilder.Entity<FirmaAntiNarcotico>(entity =>
        {
            entity.HasKey(e => e.idfirmaantinarcoticos)
                .HasName("PK__FirmaAnt__B8B99E8B40257DE4")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<FirmaAntiNarcoticosDetalle>(entity =>
        {
            entity.HasKey(e => e.idfirmaantinarcoticosdetalle)
                .HasName("PK__FirmaAnt__918C5F8943F60EC8")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<FormaPagoRecibo>(entity =>
        {
            entity.HasKey(e => e.idFormaPagoRecibo).HasName("PK__FormaPag__EDBB4BBF45BE5BA9");
        });

        modelBuilder.Entity<Frecuencium>(entity =>
        {
            entity.Property(e => e.idfrecuencia).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Gasto>(entity =>
        {
            entity.HasKey(e => e.idGasto).HasFillFactor(90);
        });

        modelBuilder.Entity<GastoAnticipo>(entity =>
        {
            entity.HasKey(e => e.idGastoAnticipo).HasName("PK__GastoAnt__57470D504AA30C57");

            entity.HasOne(d => d.idAnticipoNavigation).WithMany(p => p.GastoAnticipos).HasConstraintName("FK__GastoAnti__idAnt__108C44B2");

            entity.HasOne(d => d.idCausacionItemsNavigation).WithMany(p => p.GastoAnticipos).HasConstraintName("FK__GastoAnti__idCau__118068EB");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.GastoAnticipos).HasConstraintName("FK__GastoAnti__idGas__12748D24");

            entity.HasOne(d => d.idProcesoNavigation).WithMany(p => p.GastoAnticipos).HasConstraintName("FK__GastoAnti__idPro__1368B15D");
        });

        modelBuilder.Entity<GastoPropioAdicionalAnticipo>(entity =>
        {
            entity.HasKey(e => e.idGastoPropioAdicionalAnticipo).HasName("PK__GastoPro__1369596F4E739D3B");

            entity.HasOne(d => d.idAnticipoNavigation).WithMany(p => p.GastoPropioAdicionalAnticipos).HasConstraintName("FK__GastoProp__idAnt__145CD596");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.GastoPropioAdicionalAnticipos).HasConstraintName("FK__GastoProp__idGas__1550F9CF");
        });

        modelBuilder.Entity<GastoPropioAnticipo>(entity =>
        {
            entity.HasKey(e => e.idGastoPropioAnticipo).HasName("PK__GastoPro__93FC85E052442E1F");

            entity.HasOne(d => d.idAnticipoNavigation).WithMany(p => p.GastoPropioAnticipos).HasConstraintName("FK__GastoProp__idAnt__16451E08");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.GastoPropioAnticipos).HasConstraintName("FK__GastoProp__idGas__17394241");
        });

        modelBuilder.Entity<GastosConcepto>(entity =>
        {
            entity.HasKey(e => e.idGastoConcepto).HasFillFactor(90);
        });

        modelBuilder.Entity<Gravamene>(entity =>
        {
            entity.HasKey(e => e.idGravamen).HasFillFactor(90);

            entity.Property(e => e.fechadecaptura).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<GruposAlerta>(entity =>
        {
            entity.HasKey(e => e.IdGrupo).HasFillFactor(90);
        });

        modelBuilder.Entity<GruposAlertasUsuario>(entity =>
        {
            entity.HasKey(e => e.IdGrupoAlertas).HasFillFactor(90);
        });

        modelBuilder.Entity<INTERFAZ_ANTICIPOS_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_ANTICIPOS_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_ANTICIPOS_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_ANTICIPOS_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_CAUSACIONE>(entity =>
        {
            entity.ToView("INTERFAZ_CAUSACIONES");
        });

        modelBuilder.Entity<INTERFAZ_CAUSACIONES_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_CAUSACIONES_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_FACTURA>(entity =>
        {
            entity.ToView("INTERFAZ_FACTURAS");
        });

        modelBuilder.Entity<INTERFAZ_FACTURAS_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_FACTURAS_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_LEGALIZA_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_LEGALIZA_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_LEGALIZA_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_LEGALIZA_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_NC_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_NC_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_NC_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_NC_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_ND_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_ND_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_ND_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_ND_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_RC_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_RC_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_RC_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_RC_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_RECIBOS_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_RECIBOS_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_RECIBOS_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_RECIBOS_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_SF_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_SF_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_SF_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_SF_ENCABEZADO");
        });

        modelBuilder.Entity<INTERFAZ_TE2_DETALLE>(entity =>
        {
            entity.ToView("INTERFAZ_TE2_DETALLE");
        });

        modelBuilder.Entity<INTERFAZ_TE2_ENCABEZADO>(entity =>
        {
            entity.ToView("INTERFAZ_TE2_ENCABEZADO");
        });

        modelBuilder.Entity<IVA>(entity =>
        {
            entity.HasKey(e => e.idIVA).HasFillFactor(90);

            entity.Property(e => e.FechaUltimaActualizacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<IdentificacionONU>(entity =>
        {
            entity.HasKey(e => e.ididentificaciononu).HasFillFactor(90);
        });

        modelBuilder.Entity<IdentificacionRiesgo>(entity =>
        {
            entity.HasKey(e => e.ididentificacionriesgos).HasFillFactor(90);
        });

        modelBuilder.Entity<IndicadorCicloFacturacion>(entity =>
        {
            entity.ToView("IndicadorCicloFacturacion");
        });

        modelBuilder.Entity<IndicadorCicloFacturacionAgrupado>(entity =>
        {
            entity.ToView("IndicadorCicloFacturacionAgrupado");
        });

        modelBuilder.Entity<IndicadorOperacionOportuna>(entity =>
        {
            entity.ToView("IndicadorOperacionOportuna");
        });

        modelBuilder.Entity<IndicadorOperacionOportunaAgrupado>(entity =>
        {
            entity.ToView("IndicadorOperacionOportunaAgrupado");
        });

        modelBuilder.Entity<Indicadore>(entity =>
        {
            entity.HasKey(e => e.idIndicador).HasFillFactor(90);
        });

        modelBuilder.Entity<IndicadoresEstado>(entity =>
        {
            entity.HasKey(e => e.idIndicadoresEstado).HasFillFactor(90);
        });

        modelBuilder.Entity<IndicadoresSeguimiento>(entity =>
        {
            entity.HasKey(e => e.idindicadorseguimiento).HasFillFactor(90);
        });

        modelBuilder.Entity<Indirecto>(entity =>
        {
            entity.HasKey(e => e.idindirecto).HasFillFactor(90);
        });

        modelBuilder.Entity<InformeDinamico>(entity =>
        {
            entity.HasKey(e => e.idtablainformedinamico)
                .HasName("PK_TablaInformeDinamico")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<InformeIsa20Mayo_Crystal_Hada_Impo>(entity =>
        {
            entity.ToView("InformeIsa20Mayo_Crystal_Hada_Impo");
        });

        modelBuilder.Entity<InformeIsa20Mayo_Crystal_Hadum>(entity =>
        {
            entity.ToView("InformeIsa20Mayo_Crystal_Hada");
        });

        modelBuilder.Entity<Informe_De_Elaboracion>(entity =>
        {
            entity.ToView("Informe_De_Elaboracion");
        });

        modelBuilder.Entity<Informe_De_Elaboracion2>(entity =>
        {
            entity.ToView("Informe_De_Elaboracion2");
        });

        modelBuilder.Entity<Informe_Uap_Aduanimex>(entity =>
        {
            entity.ToView("Informe_Uap_Aduanimex");
        });

        modelBuilder.Entity<InformereciboCajaAnticipo>(entity =>
        {
            entity.ToView("InformereciboCajaAnticipo");
        });

        modelBuilder.Entity<InformereciboCajaOtro>(entity =>
        {
            entity.ToView("InformereciboCajaOtros");
        });

        modelBuilder.Entity<InstruccionesDetalle>(entity =>
        {
            entity.HasKey(e => e.idinstruccionesdetalle)
                .HasName("PK__Instrucc__004E654500FF1D08")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<Intermediario>(entity =>
        {
            entity.HasKey(e => e.idintermediario).HasFillFactor(90);
        });

        modelBuilder.Entity<ItemsTarifario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ItemsTar__3214EC07276F41F9");
        });

        modelBuilder.Entity<Kit>(entity =>
        {
            entity.Property(e => e.idusuario).IsFixedLength();
        });

        modelBuilder.Entity<LegalizacionesSinTransferencia>(entity =>
        {
            entity.ToView("LegalizacionesSinTransferencias");
        });

        modelBuilder.Entity<LetrasPermitida>(entity =>
        {
            entity.HasKey(e => e.idLetrasPermitidas).HasName("PK__LetrasPe__B606F8511411F17C");
        });

        modelBuilder.Entity<LineaTiempo>(entity =>
        {
            entity.HasKey(e => e.idLineaTiempo).HasFillFactor(90);
        });

        modelBuilder.Entity<LiquidacionExportacion>(entity =>
        {
            entity.HasKey(e => e.idliquidacionexportacion)
                .HasName("PK__Liquidac__139DFE481A9EF37A")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<LiquidacionPrebel>(entity =>
        {
            entity.ToView("LiquidacionPrebel");
        });

        modelBuilder.Entity<LiquidacionPrebelEncabezado>(entity =>
        {
            entity.ToView("LiquidacionPrebelEncabezado");
        });

        modelBuilder.Entity<LiquidacionPrebelItem>(entity =>
        {
            entity.ToView("LiquidacionPrebelItems");
        });

        modelBuilder.Entity<LiquidacionesExpoItem>(entity =>
        {
            entity.HasKey(e => e.idLiquidacionExpoItem)
                .HasName("PK_idLiquidacionExpoItem")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ListaChequeoEncabezado>(entity =>
        {
            entity.HasKey(e => e.idListaChequeoEncabezado).HasName("PK__ListaChe__C76BBA941E8F7FEF");

            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.idAsesorNavigation).WithMany(p => p.ListaChequeoEncabezadoidAsesorNavigations).HasConstraintName("FK__ListaCheq__idAse__182D667A");

            entity.HasOne(d => d.idAuxiliarNavigation).WithMany(p => p.ListaChequeoEncabezadoidAuxiliarNavigations).HasConstraintName("FK__ListaCheq__idAux__19218AB3");

            entity.HasOne(d => d.idTipoCargaNavigation).WithMany(p => p.ListaChequeoEncabezados).HasConstraintName("FK__ListaCheq__idTip__1A15AEEC");
        });

        modelBuilder.Entity<ListadoFactura>(entity =>
        {
            entity.ToView("ListadoFacturas");

            entity.Property(e => e.idfactura).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Listaempaque>(entity =>
        {
            entity.HasKey(e => e.idlistaempaque).HasFillFactor(90);
        });

        modelBuilder.Entity<Listaempaquedetalle>(entity =>
        {
            entity.HasKey(e => e.idlistaempaqueitem).HasFillFactor(90);
        });

        modelBuilder.Entity<LogRegistroMuisca>(entity =>
        {
            entity.HasKey(e => e.idLog).HasName("PK__LogRegis__3C7153CA2818EA29");
        });

        modelBuilder.Entity<LogTransaccione>(entity =>
        {
            entity.HasKey(e => e.idLogTransacciones)
                .HasName("PK__LogTrans__0EF133142FBA0BF1")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<LugarDestinoFinal>(entity =>
        {
            entity.HasKey(e => e.idlugardestinofinal).HasName("PK__LugarDes__367D39B2338A9CD5");
        });

        modelBuilder.Entity<LugarIngresoMercancia>(entity =>
        {
            entity.HasKey(e => e.idLugarIngresoMercancias).HasFillFactor(90);
        });

        modelBuilder.Entity<Madecentro_Gasto>(entity =>
        {
            entity.ToView("Madecentro_Gastos");
        });

        modelBuilder.Entity<Madecentro_GastosDetalle>(entity =>
        {
            entity.ToView("Madecentro_GastosDetalle");
        });

        modelBuilder.Entity<Madecentro_ProximoLevante>(entity =>
        {
            entity.ToView("Madecentro_ProximoLevante");
        });

        modelBuilder.Entity<Madecentro_SinAsignacion>(entity =>
        {
            entity.ToView("Madecentro_SinAsignacion");
        });

        modelBuilder.Entity<MedidaProducto>(entity =>
        {
            entity.HasKey(e => e.idmedidaprod)
                .HasName("PK_idmedidaprod")
                .HasFillFactor(90);

            entity.Property(e => e.idmedida).HasDefaultValue(1);
        });

        modelBuilder.Entity<MedidasCotizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MedidasC__3214EC07E8991C26");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.MedidasCotizacions).HasConstraintName("FK__MedidasCo__Cotiz__4CAC1BB1");
        });

        modelBuilder.Entity<Mercado>(entity =>
        {
            entity.HasKey(e => e.idmercado).HasName("PK_mercado");
        });

        modelBuilder.Entity<Minima>(entity =>
        {
            entity.HasKey(e => e.iddescripcion).HasFillFactor(90);
        });

        modelBuilder.Entity<MinimaDetalle>(entity =>
        {
            entity.HasKey(e => e.idminimadetalle).HasFillFactor(90);
        });

        modelBuilder.Entity<MinimasCatalogoP>(entity =>
        {
            entity.HasKey(e => e.idminimacatalogop)
                .HasName("PK_MinimaCatalogoP")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<MinimasCatalogoPImpo>(entity =>
        {
            entity.HasKey(e => e.idminimacatalogop)
                .HasName("PK_MinimaCatalogoPImpo")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<MinimasEncabezado>(entity =>
        {
            entity.HasKey(e => e.idarancel).HasFillFactor(90);
        });

        modelBuilder.Entity<MinimasRelacion>(entity =>
        {
            entity.HasKey(e => e.idrelacion).HasFillFactor(90);
        });

        modelBuilder.Entity<Modalidade>(entity =>
        {
            entity.HasKey(e => e.idmodalidad).HasFillFactor(90);
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.idMunicipio).HasFillFactor(90);
        });

        modelBuilder.Entity<Naviera>(entity =>
        {
            entity.HasKey(e => e.idnaviera).HasFillFactor(90);
        });

        modelBuilder.Entity<NotaRemisoriadetalle>(entity =>
        {
            entity.HasKey(e => e.idNotadetalle).HasName("PK__NotaRemi__4AFA906C59B045BD");
        });

        modelBuilder.Entity<NotasReciboCaja>(entity =>
        {
            entity.HasKey(e => e.idNotaReciboCaja).HasName("PK__NotasRec__8576F0663A4CA8FD");
        });

        modelBuilder.Entity<Notificacione>(entity =>
        {
            entity.HasKey(e => e.idNotificacion).HasFillFactor(90);

            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.prioridad).HasDefaultValue((short)2);
        });

        modelBuilder.Entity<NotificacionesLeidasUsuario>(entity =>
        {
            entity.HasKey(e => e.idnotificacionleida).HasFillFactor(90);
        });

        modelBuilder.Entity<Novedad>(entity =>
        {
            entity.HasKey(e => e.idNovedad).HasName("PK__Novedad__CD11A51661516785");
        });

        modelBuilder.Entity<NovedadUsuario>(entity =>
        {
            entity.HasKey(e => e.idNovedadUsuario).HasName("PK__NovedadU__AFAE9EDB6521F869");
        });

        modelBuilder.Entity<NrosplanillaT>(entity =>
        {
            entity.HasKey(e => e.nroformularioreservado).HasFillFactor(90);
        });

        modelBuilder.Entity<NumerosEnvio>(entity =>
        {
            entity.HasKey(e => e.NEnvio)
                .HasName("PK_estado")
                .HasFillFactor(90);

            entity.Property(e => e.NEnvio).ValueGeneratedNever();
        });

        modelBuilder.Entity<NumerosEnvioPlanilla>(entity =>
        {
            entity.HasKey(e => e.NEnvio)
                .HasName("PK_nroenvioplanilla")
                .HasFillFactor(90);

            entity.Property(e => e.NEnvio).ValueGeneratedNever();
        });

        modelBuilder.Entity<OficinasComercializadora>(entity =>
        {
            entity.HasKey(e => e.idoficinacomercializadora).HasFillFactor(90);
        });

        modelBuilder.Entity<OficinasOperativa>(entity =>
        {
            entity.HasKey(e => e.idoficinaoperativa).HasFillFactor(90);
        });

        modelBuilder.Entity<OpcionesxPerfil>(entity =>
        {
            entity.HasKey(e => e.id_formulario).HasName("PK__Opciones__05B111FD7834CCDD");
        });

        modelBuilder.Entity<Operacione>(entity =>
        {
            entity.ToView("Operaciones");
        });

        modelBuilder.Entity<OperacionesDO>(entity =>
        {
            entity.HasKey(e => e.idOperacionDO).HasFillFactor(90);
        });

        modelBuilder.Entity<OperacionesEXPO>(entity =>
        {
            entity.ToView("OperacionesEXPO");
        });

        modelBuilder.Entity<OperacionesExportacion>(entity =>
        {
            entity.ToView("OperacionesExportacion");
        });

        modelBuilder.Entity<OperacionesExportacionDetalle>(entity =>
        {
            entity.ToView("OperacionesExportacionDetalle");
        });

        modelBuilder.Entity<OperacionesImpoDTum>(entity =>
        {
            entity.ToView("OperacionesImpoDTA");
        });

        modelBuilder.Entity<Ordendecompra>(entity =>
        {
            entity.HasKey(e => e.idordendecompra).HasFillFactor(90);

            entity.Property(e => e.idlugardestino).IsFixedLength();
            entity.Property(e => e.nestado).HasDefaultValueSql("((0))");
            entity.Property(e => e.zonafranca).HasDefaultValue(false);
        });

        modelBuilder.Entity<Ordendecompraitem>(entity =>
        {
            entity.HasKey(e => e.idordendecompraitem).HasFillFactor(90);
        });

        modelBuilder.Entity<PRUEBADBMLBORRAR>(entity =>
        {
            entity.HasKey(e => e.iddbml).HasFillFactor(90);

            entity.Property(e => e.iddbml).IsFixedLength();
            entity.Property(e => e.sdfsdf).IsFixedLength();
        });

        modelBuilder.Entity<PalabrasEspeciale>(entity =>
        {
            entity.HasKey(e => e.idPalabraEspecial).HasName("PK__Palabras__77DCD9D9058EC7FB");
        });

        modelBuilder.Entity<PlaneacionTransporte>(entity =>
        {
            entity.ToView("PlaneacionTransporte");
        });

        modelBuilder.Entity<PlanoPagosSeleccion>(entity =>
        {
            entity.ToView("PlanoPagosSeleccion");
        });

        modelBuilder.Entity<PlanoPagosSeleccionCliente>(entity =>
        {
            entity.ToView("PlanoPagosSeleccionClientes");
        });

        modelBuilder.Entity<Poliza>(entity =>
        {
            entity.HasKey(e => e.idPoliza).HasFillFactor(90);
        });

        modelBuilder.Entity<PrefiltrosReporte>(entity =>
        {
            entity.HasKey(e => e.idPrefiltrosReporte).HasFillFactor(90);
        });

        modelBuilder.Entity<Preliquidacion>(entity =>
        {
            entity.HasKey(e => e.idPreliquidacion).HasFillFactor(90);
        });

        modelBuilder.Entity<ProcesoAnticipo>(entity =>
        {
            entity.HasKey(e => e.idProcesoAnticipo).HasName("PK__ProcesoA__663EFAFA17AD7836");
        });

        modelBuilder.Entity<ProcesoAnticipoDetalle>(entity =>
        {
            entity.HasKey(e => e.idProcesoAnticipoDetalle).HasName("PK__ProcesoA__53B502CF1B7E091A");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.ProcesoAnticipoDetalles).HasConstraintName("FK__ProcesoAn__idGas__1B09D325");

            entity.HasOne(d => d.idProcesoAnticipoNavigation).WithMany(p => p.ProcesoAnticipoDetalles).HasConstraintName("FK__ProcesoAn__idPro__1BFDF75E");
        });

        modelBuilder.Entity<ProcesoGastoAnticipo>(entity =>
        {
            entity.HasKey(e => e.idProcesoGastoAnticipo).HasName("PK__ProcesoG__F05C58F71F4E99FE");

            entity.HasOne(d => d.idAnticipoNavigation).WithMany(p => p.ProcesoGastoAnticipos).HasConstraintName("FK__ProcesoGa__idAnt__1CF21B97");

            entity.HasOne(d => d.idProcesoNavigation).WithMany(p => p.ProcesoGastoAnticipos).HasConstraintName("FK__ProcesoGa__idPro__00B50445");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.idproducto).HasFillFactor(90);
        });

        modelBuilder.Entity<ProductosEliminado>(entity =>
        {
            entity.HasKey(e => e.idproductoeliminado).HasFillFactor(90);
        });

        modelBuilder.Entity<ProductosEliminadosimpo>(entity =>
        {
            entity.HasKey(e => e.idproductoeliminadoimpo)
                .HasName("PK_ProductosEliminadoimpo")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<RadicadoMuisca>(entity =>
        {
            entity.HasKey(e => e.idRadicadoMuisca).HasName("PK__Radicado__13E7FEEB3EC74557");
        });

        modelBuilder.Entity<RadicadosEdiFac>(entity =>
        {
            entity.HasKey(e => e.idRadicadosEdiFac).HasName("PK__Radicado__432D4D5B5812160E");

            entity.HasOne(d => d.idDeclaracionNavigation).WithMany(p => p.RadicadosEdiFacs).HasConstraintName("FK__Radicados__idDec__029D4CB7");
        });

        modelBuilder.Entity<ReciboCajaAnticipo>(entity =>
        {
            entity.HasKey(e => e.idReciboCajaAnticipo).HasName("PK__ReciboCa__07CE2C95498EEC8D");

            entity.HasOne(d => d.idBancoNavigation).WithMany(p => p.ReciboCajaAnticipoidBancoNavigations).HasConstraintName("FK__ReciboCaj__idBan__076201D4");

            entity.HasOne(d => d.idBancoTrasladoNavigation).WithMany(p => p.ReciboCajaAnticipoidBancoTrasladoNavigations).HasConstraintName("FK__ReciboCaj__idBan__0856260D");

            entity.HasOne(d => d.idClienteNavigation).WithMany(p => p.ReciboCajaAnticipos).HasConstraintName("FK__ReciboCaj__idCli__094A4A46");

            entity.HasOne(d => d.idDoOtroConceptoNavigation).WithMany(p => p.ReciboCajaAnticipos).HasConstraintName("FK__ReciboCaj__idDoO__0A3E6E7F");

            entity.HasOne(d => d.idFormaPagoNavigation).WithMany(p => p.ReciboCajaAnticipos).HasConstraintName("FK__ReciboCaj__idFor__0B3292B8");

            entity.HasOne(d => d.idGastoNavigation).WithMany(p => p.ReciboCajaAnticipos).HasConstraintName("FK__ReciboCaj__idGas__0C26B6F1");

            entity.HasOne(d => d.idLugarIngresoMercanciasNavigation).WithMany(p => p.ReciboCajaAnticipos).HasConstraintName("FK__ReciboCaj__idLug__0D1ADB2A");

            entity.HasOne(d => d.idTerceroNavigation).WithMany(p => p.ReciboCajaAnticipos).HasConstraintName("FK__ReciboCaj__idTer__0E0EFF63");
        });

        modelBuilder.Entity<ReciboCajaMenor>(entity =>
        {
            entity.HasKey(e => e.idReciboCajaMenor).HasName("PK__ReciboCa__7A8CACD66D9742D9");

            entity.HasOne(d => d.idCiudadNavigation).WithMany(p => p.ReciboCajaMenors).HasConstraintName("FK__ReciboCaj__idCiu__0F03239C");

            entity.HasOne(d => d.idClienteNavigation).WithMany(p => p.ReciboCajaMenors).HasConstraintName("FK__ReciboCaj__idCli__0FF747D5");

            entity.HasOne(d => d.idDoNavigation).WithMany(p => p.ReciboCajaMenors).HasConstraintName("FK__ReciboCaja__idDo__12D3B480");

            entity.HasOne(d => d.idTerceroNavigation).WithMany(p => p.ReciboCajaMenors).HasConstraintName("FK__ReciboCaj__idTer__10EB6C0E");

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.ReciboCajaMenors).HasConstraintName("FK__ReciboCaj__idUsu__11DF9047");
        });

        modelBuilder.Entity<RecibosCajaFactura>(entity =>
        {
            entity.ToView("RecibosCajaFacturas");
        });

        modelBuilder.Entity<Reembolso>(entity =>
        {
            entity.HasKey(e => e.idreembolzo)
                .HasName("PK_Reembolzos")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<Regione>(entity =>
        {
            entity.HasKey(e => e.idregion).HasName("PK__Regiones__E604EA2A4668671F");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.idregistro).HasFillFactor(90);
        });

        modelBuilder.Entity<RegistroImportacion>(entity =>
        {
            entity.HasKey(e => e.idRegistroImportacion).HasFillFactor(90);
        });

        modelBuilder.Entity<RegistroImportacionItemsCom>(entity =>
        {
            entity.HasKey(e => e.iddetalleRegistrocomplemento).HasFillFactor(90);
        });

        modelBuilder.Entity<RegistroImportacionesItem>(entity =>
        {
            entity.HasKey(e => e.idRegistroItem).HasFillFactor(90);
        });

        modelBuilder.Entity<RelacionDefecto>(entity =>
        {
            entity.HasKey(e => e.idrelaciondefecto).HasFillFactor(90);
        });

        modelBuilder.Entity<RelacionFormulario>(entity =>
        {
            entity.HasKey(e => e.idrelacionformulario).HasFillFactor(90);
        });

        modelBuilder.Entity<RelacionGasto>(entity =>
        {
            entity.HasKey(e => e.idrelaciongastos).HasFillFactor(90);
        });

        modelBuilder.Entity<RelacionGastosItem>(entity =>
        {
            entity.HasKey(e => e.idrelaciongastositem).HasFillFactor(90);
        });

        modelBuilder.Entity<RelacionesInformeDinamico>(entity =>
        {
            entity.HasKey(e => e.idtablarelacioninformedinamico).HasFillFactor(90);
        });

        modelBuilder.Entity<ReportDeclaracionImportacion>(entity =>
        {
            entity.ToView("ReportDeclaracionImportacion");

            entity.Property(e => e.Cod_Producto).IsFixedLength();
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("Numero unico que identifica el registro dentro de la tabla");
            entity.Property(e => e.NombreReporte).HasComment("Nombre del reporte");
            entity.Property(e => e.Tabla_Vista).HasComment("Nombre de la tabla o vista que compone el reporte");
        });

        modelBuilder.Entity<ReportesColumna>(entity =>
        {
            entity.Property(e => e.Alineacion).HasComment("alineacion de la columna en el reporte (izq, der, centro)");
            entity.Property(e => e.Ancho).HasComment("Porcentaje del ancho de la columna");
            entity.Property(e => e.Columna).HasComment("Nombre de la columna en la tabla o vista");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("Numero unico que identifica el registro dentro de la tabla");
            entity.Property(e => e.IdReporte).HasComment("Numero del reporte al cual pertenecen las columnas");
            entity.Property(e => e.Identificador).HasComment("SÃ­ tiene el valor de uno el campo que identifica al registro para su edicion o eliminacion o modificacion");
            entity.Property(e => e.Orden).HasComment("Orden en que deben aparecer los campos en el reporte");
            entity.Property(e => e.Titulo).HasComment("Titulo a ser mostrado en el resultado de la consulta");
            entity.Property(e => e.VinculoEditar).HasComment("Si tiene un 1, sera el campo con el vinculo para la edicion del registro");
        });

        modelBuilder.Entity<ReportesUsuario>(entity =>
        {
            entity.HasKey(e => e.IdReporteUsuario).HasFillFactor(90);
        });

        modelBuilder.Entity<RutasNombreDO>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__RutasNom__3213E83F63F8CA06");
        });

        modelBuilder.Entity<SIA>(entity =>
        {
            entity.HasKey(e => e.idsia).HasFillFactor(90);
        });

        modelBuilder.Entity<SaldoDO>(entity =>
        {
            entity.ToView("SaldoDO");
        });

        modelBuilder.Entity<SaldosAFavor>(entity =>
        {
            entity.HasKey(e => e.idsaldoafavor).HasName("PK_idsaldoafavor");
        });

        modelBuilder.Entity<SegmentosEDIFAC>(entity =>
        {
            entity.HasKey(e => e.idSegmento).HasFillFactor(90);
        });

        modelBuilder.Entity<Seguimiento>(entity =>
        {
            entity.HasKey(e => e.idSeguimiento).HasFillFactor(90);
        });

        modelBuilder.Entity<SeguimientoItem>(entity =>
        {
            entity.HasKey(e => e.idSeguimientoItem).HasFillFactor(90);

            entity.Property(e => e.Semaforo).HasDefaultValue("VERDE");
        });

        modelBuilder.Entity<SeguimientoItemEvento>(entity =>
        {
            entity.HasKey(e => e.idSeguimientoItemEvento).HasFillFactor(90);

            entity.Property(e => e.fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.idServicio).HasFillFactor(90);
        });

        modelBuilder.Entity<ServiciosPorDO>(entity =>
        {
            entity.HasKey(e => e.idServiciosPorDO).HasName("PK__Servicio__703F60862DD28ED6");
        });

        modelBuilder.Entity<ServiciosPorTarifa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC075FB513FB");
        });

        modelBuilder.Entity<ServiciosxEmpresa>(entity =>
        {
            entity.HasKey(e => e.idservicioempresa).HasFillFactor(90);
        });

        modelBuilder.Entity<Signatario>(entity =>
        {
            entity.HasKey(e => e.idsignatario)
                .HasName("PK__Signatar__DC1BA92079E80B25")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<SituacionDO>(entity =>
        {
            entity.HasKey(e => e.idComentario).HasName("PK_ComentariosDO");
        });

        modelBuilder.Entity<Situacion_Negocio>(entity =>
        {
            entity.ToView("Situacion_Negocios");

            entity.Property(e => e.ETA).IsFixedLength();
            entity.Property(e => e.ETD).IsFixedLength();
        });

        modelBuilder.Entity<SolicitudCliente>(entity =>
        {
            entity.HasKey(e => e.idSolicitudCliente)
                .HasName("PK_SolicitudClientes")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<SoporteDim>(entity =>
        {
            entity.HasKey(e => e.idSoporteDim).HasName("PK__SoporteD__45FE51040371755F");

            entity.Property(e => e.Presentado).HasDefaultValue(true);

            entity.HasOne(d => d.idDeclaracionNavigation).WithMany(p => p.SoporteDims).HasConstraintName("FK__SoporteDi__idDec__13C7D8B9");

            entity.HasOne(d => d.idTipoDocumentoNavigation).WithMany(p => p.SoporteDims).HasConstraintName("FK__SoporteDi__idTip__14BBFCF2");
        });

        modelBuilder.Entity<SubpartidasComplemento>(entity =>
        {
            entity.HasKey(e => e.idcomplemento).HasFillFactor(90);
        });

        modelBuilder.Entity<Suceso>(entity =>
        {
            entity.HasKey(e => e.idSuceso).HasFillFactor(90);
        });

        modelBuilder.Entity<SucesosLectura>(entity =>
        {
            entity.HasKey(e => e.idSucesosLectura).HasFillFactor(90);
        });

        modelBuilder.Entity<TablaNuevo>(entity =>
        {
            entity.Property(e => e.idtemporalnuevo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TablaTviejo>(entity =>
        {
            entity.Property(e => e.idtemporalviejo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TamanioContenedorFull>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TamanioC__3214EC07F53E18A4");
        });

        modelBuilder.Entity<TamanoContenedor>(entity =>
        {
            entity.HasKey(e => e.idtamanocontenedor).HasFillFactor(90);
        });

        modelBuilder.Entity<TarifaMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TarifaMa__3214EC07D58644C4");
        });

        modelBuilder.Entity<TarifaMasterItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TarifaMa__3214EC07092541AB");
        });

        modelBuilder.Entity<Tarifario>(entity =>
        {
            entity.HasKey(e => e.idtarifario).HasName("PK__Tarifari__6A0B35741590259A");
        });

        modelBuilder.Entity<TarifarioAdjunto>(entity =>
        {
            entity.HasKey(e => e.idTarifarioAdjuntos).HasName("PK__Tarifari__7236262E1960B67E");
        });

        modelBuilder.Entity<TarifarioContenedor>(entity =>
        {
            entity.HasKey(e => e.idTarifarioContenedor)
                .HasName("PK__Tarifari__1A19134D1D314762")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<TarifarioContenedorCE>(entity =>
        {
            entity.HasKey(e => e.idTarifarioContenedorCE)
                .HasName("PK__Tarifari__D6130F202101D846")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<TarifarioContenedoritem>(entity =>
        {
            entity.HasKey(e => e.idTarifarioContenedoritem)
                .HasName("PK__Tarifari__C7882EC224D2692A")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<TarifarioItem>(entity =>
        {
            entity.HasKey(e => e.idTarifarioItem).HasName("PK__Tarifari__9B9ECEA928A2FA0E");
        });

        modelBuilder.Entity<TarifarioTerrestre>(entity =>
        {
            entity.HasKey(e => e.idTarifarioTerrestre)
                .HasName("PK__Tarifari__620208F72C738AF2")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<TarifarioTerrestreItem>(entity =>
        {
            entity.HasKey(e => e.idTarifarioterrestreItem)
                .HasName("PK__Tarifari__B2F4908E30441BD6")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<TarifasCotizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TarifasC__3214EC07F684ADFF");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.TarifasCotizacions).HasConstraintName("FK__TarifasCo__Cotiz__4E946423");
        });

        modelBuilder.Entity<Tb_ConsecutivoCotizacione>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Tb_Conse__3213E83F0E6B84CD");
        });

        modelBuilder.Entity<Tb_ConsecutivoTarifaMaster>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Tb_Conse__3213E83F96FB8B77");
        });

        modelBuilder.Entity<Tb_ConsecutivoTarifario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tb_Conse__3214EC079EE646D9");
        });

        modelBuilder.Entity<Tercero>(entity =>
        {
            entity.HasKey(e => e.idTercero).HasName("PK_Terceros2");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.iddocumento).HasFillFactor(90);
        });

        modelBuilder.Entity<TipoEquipo>(entity =>
        {
            entity.HasKey(e => e.idtipoequipo).HasFillFactor(90);
        });

        modelBuilder.Entity<TipoEstado>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TipoImportacion>(entity =>
        {
            entity.HasKey(e => e.idtipoimportacion).HasFillFactor(90);
        });

        modelBuilder.Entity<TipoNegociacion>(entity =>
        {
            entity.Property(e => e.idtiponegociacion).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TiposDeDocumento>(entity =>
        {
            entity.Property(e => e.idtipodedocumento).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TransportadorNacional>(entity =>
        {
            entity.HasKey(e => e.idtransportadornacional).HasFillFactor(90);
        });

        modelBuilder.Entity<TransporteTerrestre>(entity =>
        {
            entity.HasKey(e => e.idtransporteterrestre)
                .HasName("PK__Transpor__20A55CFE2DB1C7EE")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<TransporteTerrestreDetalle>(entity =>
        {
            entity.HasKey(e => e.idtransporteterrestredetalle)
                .HasName("PK__Transpor__82D73C0F3552E9B6")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<Traslado>(entity =>
        {
            entity.HasKey(e => e.idtraslado).HasFillFactor(90);
        });

        modelBuilder.Entity<TrasladosAnexo>(entity =>
        {
            entity.HasKey(e => e.idtrasladoanexo).HasFillFactor(90);
        });

        modelBuilder.Entity<TrazabilidadNovaTrack>(entity =>
        {
            entity.ToView("TrazabilidadNovaTrack");
        });

        modelBuilder.Entity<Trm>(entity =>
        {
            entity.HasKey(e => e.idtrm).HasFillFactor(90);
        });

        modelBuilder.Entity<UnidadCarga>(entity =>
        {
            entity.HasKey(e => e.idunidadcarga).HasFillFactor(90);
        });

        modelBuilder.Entity<UsuarioMuisca>(entity =>
        {
            entity.HasKey(e => e.idUsuarioMuisca).HasName("PK__UsuarioM__2C3A71D12962141D");
        });

        modelBuilder.Entity<UsuarioSigloXXI>(entity =>
        {
            entity.HasKey(e => e.idUsuarioSigloXXI).HasName("PK__UsuarioS__C667BA2A2E26C93A");

            entity.Property(e => e.Habilitado).HasDefaultValue(true);

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.UsuarioSigloXXIs).HasConstraintName("FK__UsuarioSi__idUsu__1798699D");
        });

        modelBuilder.Entity<UsuarioSigloXXIDetalle>(entity =>
        {
            entity.HasKey(e => e.idUsuarioSigloXXIDetalle).HasName("PK__UsuarioS__053F20D731F75A1E");

            entity.HasOne(d => d.idAduanaNavigation).WithMany(p => p.UsuarioSigloXXIDetalles).HasConstraintName("FK__UsuarioSi__idAdu__188C8DD6");

            entity.HasOne(d => d.idUsuarioSigloXXINavigation).WithMany(p => p.UsuarioSigloXXIDetalles).HasConstraintName("FK__UsuarioSi__idUsu__1980B20F");
        });

        modelBuilder.Entity<UsuariosOnLine>(entity =>
        {
            entity.HasKey(e => e.idUsuarioOnLine).HasFillFactor(90);

            entity.Property(e => e.ingreso).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ValidacionIndicadore>(entity =>
        {
            entity.ToView("ValidacionIndicadores");
        });

        modelBuilder.Entity<ValoresGasto>(entity =>
        {
            entity.HasKey(e => e.idValoresGastos).HasFillFactor(90);
        });

        modelBuilder.Entity<VinculoDocumentosExpo>(entity =>
        {
            entity.HasKey(e => e.IdVinculoDocumentosExpo)
                .HasName("PK__VinculoD__659BB13F3B80C458")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<VinculoDocumentosImpo>(entity =>
        {
            entity.HasKey(e => e.IdVinculoDocumentos).HasFillFactor(90);
        });

        modelBuilder.Entity<VistosBueno>(entity =>
        {
            entity.HasKey(e => e.idvistobueno).HasFillFactor(90);
        });

        modelBuilder.Entity<VistosBuenosMincomercio>(entity =>
        {
            entity.HasKey(e => e.idVistoBueno).HasFillFactor(90);
        });

        modelBuilder.Entity<VueltasMensajerium>(entity =>
        {
            entity.HasKey(e => e.idVuelta).HasName("PK__VueltasM__AC4B251F48DABF76");
        });

        modelBuilder.Entity<aduana>(entity =>
        {
            entity.HasKey(e => e.idaduana).HasFillFactor(90);
        });

        modelBuilder.Entity<agentesenelexterior>(entity =>
        {
            entity.HasKey(e => e.idagenteexterior).HasName("PK__agentese__803C8F30479260D9");
        });

        modelBuilder.Entity<autorizacionembarque>(entity =>
        {
            entity.HasKey(e => e.idautorizacionembarque)
                .HasName("PK_exportaciones")
                .HasFillFactor(90);

            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.UltimaModificacion).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.idUsuarioDigitator).HasDefaultValue((short)0);
            entity.Property(e => e.idUsuarioRevisor).HasDefaultValue((short)0);
            entity.Property(e => e.idtipodeoperacion).HasDefaultValue(0);
            entity.Property(e => e.nroEnvio).HasDefaultValue(0);
        });

        modelBuilder.Entity<causacionesencabezado>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaCausacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.idBancoNavigation).WithMany(p => p.causacionesencabezados).HasConstraintName("FK__causacion__idBan__5C77A3CF");

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.causacionesencabezados).HasConstraintName("FK__causacion__idUsu__5D6BC808");
        });

        modelBuilder.Entity<causacionesitemsanticipo>(entity =>
        {
            entity.HasKey(e => e.idcausacionitemsxanticipo).HasName("PK_causacionesitemsxanticipo");
        });

        modelBuilder.Entity<causacionesreporte>(entity =>
        {
            entity.ToView("causacionesreporte");
        });

        modelBuilder.Entity<claseembalaje>(entity =>
        {
            entity.HasKey(e => e.idembalaje).HasFillFactor(90);
        });

        modelBuilder.Entity<comisionesxempresadetalle>(entity =>
        {
            entity.HasKey(e => e.idcomisiondetalle)
                .HasName("PK__comision__CFDBA5D37ABC33CD")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<consignatario>(entity =>
        {
            entity.HasKey(e => e.idconsignatario).HasFillFactor(90);
        });

        modelBuilder.Entity<correspondenciaSucursal>(entity =>
        {
            entity.HasKey(e => e.idCorrespondencia).HasName("PK__correspo__BC78E9D43AA1AEB8");
        });

        modelBuilder.Entity<costo>(entity =>
        {
            entity.ToView("costos");
        });

        modelBuilder.Entity<cuadros_insumos_producto>(entity =>
        {
            entity.Property(e => e.CONSECUTIVO_PROGRAMA).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.LETRAS_PROGRAMA).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.VALOR_EXPORTADO).HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<declaracionImportacion>(entity =>
        {
            entity.HasKey(e => e.iddeclaimpo).HasFillFactor(90);

            entity.Property(e => e.codproducto).IsFixedLength();
        });

        modelBuilder.Entity<declaracione>(entity =>
        {
            entity.HasKey(e => e.iddeclaracion).HasFillFactor(90);

            entity.Property(e => e.IdRegistro).HasDefaultValue(0);
            entity.Property(e => e.idInsumoRegistro).HasDefaultValue(0);
        });

        modelBuilder.Entity<declaracionesitem>(entity =>
        {
            entity.HasKey(e => e.iddetalle).HasFillFactor(90);
        });

        modelBuilder.Entity<declarante>(entity =>
        {
            entity.HasKey(e => e.iddeclarante).HasFillFactor(90);

            entity.Property(e => e.cedula).IsFixedLength();
            entity.Property(e => e.nombreasignatario).IsFixedLength();
        });

        modelBuilder.Entity<depositohabilitado>(entity =>
        {
            entity.HasKey(e => e.iddepositohabilitado).HasFillFactor(90);
        });

        modelBuilder.Entity<destinatario>(entity =>
        {
            entity.HasKey(e => e.iddestinatario).HasFillFactor(90);
        });

        modelBuilder.Entity<detalledeclaimpo>(entity =>
        {
            entity.HasKey(e => e.iddetalledeclaimpo).HasFillFactor(90);
        });

        modelBuilder.Entity<detalledeclaracionandinadelvalor>(entity =>
        {
            entity.HasKey(e => e.iddetalledeclaandinavalor).HasFillFactor(90);
        });

        modelBuilder.Entity<detallefacturaimportacion>(entity =>
        {
            entity.HasKey(e => e.iddetallefacturaimportacion).HasFillFactor(90);
        });

        modelBuilder.Entity<documento>(entity =>
        {
            entity.HasKey(e => e.id).HasFillFactor(90);

            entity.HasIndex(e => e.id, "IX_documento")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.id).HasComment("Número unico que identifica el documento");
            entity.Property(e => e.campoFiltro).HasComment("Nombre del procedimiento almacenado dentro de la base datos");
            entity.Property(e => e.nombre).HasComment("Nombre del documento o formulario");
            entity.Property(e => e.numeroPaginas).HasComment("Cantidad de paginas que conforman el documento o formulario");
        });

        modelBuilder.Entity<documentoDetalle>(entity =>
        {
            entity.HasKey(e => e.id).HasFillFactor(90);

            entity.Property(e => e.descripcion).HasComment("Nombre de la sección que compone el documento");
            entity.Property(e => e.filasPorPagina).HasComment("Cantidad de veces que aparece el dato dentro de la pagina");
            entity.Property(e => e.idDocumento).HasComment("Identificador dentro de la tabla documento");
            entity.Property(e => e.numeroPagina).HasComment("Es la pagina en la que se encuentra la variable");
            entity.Property(e => e.query).HasComment("Consulta SQL para recuperar la informacion de la seccion de la pagina");
            entity.Property(e => e.tipoPagina).HasComment("tipo pagina esta entre los valores Frente o Dorso");

            entity.HasOne(d => d.idDocumentoNavigation).WithMany(p => p.documentoDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_documentoDetalle_documento");
        });

        modelBuilder.Entity<documentotransportedetallecontenedore>(entity =>
        {
            entity.HasKey(e => e.idbldetalle).HasFillFactor(90);
        });

        modelBuilder.Entity<documentotransportedetallemercancia>(entity =>
        {
            entity.HasKey(e => e.idbldetallemercancias).HasFillFactor(90);
        });

        modelBuilder.Entity<encabezadoleonisa>(entity =>
        {
            entity.ToView("encabezadoleonisa");
        });

        modelBuilder.Entity<eu>(entity =>
        {
            entity.HasKey(e => e.ideu).HasFillFactor(90);

            entity.Property(e => e.idestado).IsFixedLength();
        });

        modelBuilder.Entity<eventoEstado>(entity =>
        {
            entity.HasKey(e => e.idEventoEstado).HasFillFactor(90);
        });

        modelBuilder.Entity<exportador>(entity =>
        {
            entity.HasKey(e => e.idexportador).HasFillFactor(90);

            entity.Property(e => e.dv).HasDefaultValueSql("((0))");
            entity.Property(e => e.habilitado).HasDefaultValue(true);
            entity.Property(e => e.nrodocumentoCamaraComercio).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoCircular).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoCrepresentante).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoEstado).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoEstudio).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoReferenciaBanc).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoRegiscliente).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoRut).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoSeguridad).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoVistaSeguridad).HasDefaultValue("");
            entity.Property(e => e.nrodocumentoreferenciaComer).HasDefaultValue("");
        });

        modelBuilder.Entity<facturacionaduana>(entity =>
        {
            entity.HasKey(e => e.idfacturacionaduana)
                .HasName("PK__facturacionaduan__194BA7E5")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<facturacionaduanadetalle>(entity =>
        {
            entity.HasKey(e => e.idfacturacionaduanadetalle)
                .HasName("PK__facturacionaduan__1B33F057")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<facturaexpo>(entity =>
        {
            entity.HasKey(e => e.idfactura).HasFillFactor(90);
        });

        modelBuilder.Entity<formapago>(entity =>
        {
            entity.HasKey(e => e.idformapago).HasFillFactor(90);
        });

        modelBuilder.Entity<impoporembar>(entity =>
        {
            entity.ToView("impoporembar");
        });

        modelBuilder.Entity<impoporproveedor>(entity =>
        {
            entity.ToView("impoporproveedor");
        });

        modelBuilder.Entity<importadore>(entity =>
        {
            entity.HasKey(e => e.idimportador).HasFillFactor(90);
        });

        modelBuilder.Entity<impresora>(entity =>
        {
            entity.HasIndex(e => e.nombre, "IX_impresora")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasComment("Número unico que identifica la impresora");
            entity.Property(e => e.nombre).HasComment("Nombre de la impresora");
        });

        modelBuilder.Entity<incoterm>(entity =>
        {
            entity.HasKey(e => e.idincoterm).HasFillFactor(90);
        });

        modelBuilder.Entity<informeFacturacion>(entity =>
        {
            entity.ToView("informeFacturacion");
        });

        modelBuilder.Entity<informecontenedore>(entity =>
        {
            entity.ToView("informecontenedores");
        });

        modelBuilder.Entity<instruccione>(entity =>
        {
            entity.HasKey(e => e.idinstrucciones)
                .HasName("PK__instrucc__748ACFB0795DFB40")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<instruccionesdespacho>(entity =>
        {
            entity.HasKey(e => e.idinstrucciondespacho)
                .HasName("PK__instrucc__F62798FF7D2E8C24")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<insumo>(entity =>
        {
            entity.HasKey(e => e.idinsumo).HasFillFactor(90);

            entity.Property(e => e.bloqueado).HasDefaultValue(false);
        });

        modelBuilder.Entity<liquidacionleonisa>(entity =>
        {
            entity.ToView("liquidacionleonisa");
        });

        modelBuilder.Entity<logRobotSiglo>(entity =>
        {
            entity.HasKey(e => e.idlogRobotSiglo).HasName("PK__logRobot__DDE99B4A2BE97B0D");
        });

        modelBuilder.Entity<logUsuarioClave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__logUsuar__3214EC0774D26F66");
        });

        modelBuilder.Entity<lugardestino>(entity =>
        {
            entity.HasKey(e => e.idlugardestino).HasFillFactor(90);
        });

        modelBuilder.Entity<lugarembarque>(entity =>
        {
            entity.HasKey(e => e.idlugarembarque).HasFillFactor(90);
        });

        modelBuilder.Entity<lugarinspeccion>(entity =>
        {
            entity.HasKey(e => e.idlugarinspeccion).HasFillFactor(90);
        });

        modelBuilder.Entity<message>(entity =>
        {
            entity.HasKey(e => e.message_id).HasFillFactor(90);

            entity.Property(e => e.leido).HasDefaultValue(false);
            entity.Property(e => e.post_time).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<migracionotek>(entity =>
        {
            entity.Property(e => e.tipo).IsFixedLength();
        });

        modelBuilder.Entity<minimas1>(entity =>
        {
            entity.HasKey(e => e.idminima1)
                .HasName("PK_Minimas1")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<minimas2>(entity =>
        {
            entity.HasKey(e => e.idMinima2)
                .HasName("PK_Minimas2")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<minimas3>(entity =>
        {
            entity.HasKey(e => e.idminima3)
                .HasName("PK_Minimas3")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<modotransporte>(entity =>
        {
            entity.HasKey(e => e.idmodotransporte).HasFillFactor(90);
        });

        modelBuilder.Entity<moneda>(entity =>
        {
            entity.HasKey(e => e.idmoneda).HasFillFactor(90);
        });

        modelBuilder.Entity<naturalezatransaccion>(entity =>
        {
            entity.HasKey(e => e.idnaturalezatransaccion).HasFillFactor(90);
        });

        modelBuilder.Entity<naturalezatransaccionimpo>(entity =>
        {
            entity.Property(e => e.idnaturalezatransaccionimpo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<notacredito>(entity =>
        {
            entity.ToView("notacredito");
        });

        modelBuilder.Entity<nrosFraccionada>(entity =>
        {
            entity.HasKey(e => e.nroFraccionada)
                .HasName("PK_nrosreservadosFraccionadas")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<nrosreservado>(entity =>
        {
            entity.HasKey(e => e.nroformularioreservado).HasFillFactor(90);
        });

        modelBuilder.Entity<ordendecompradetalle>(entity =>
        {
            entity.HasKey(e => e.idordendecompradetalle).HasFillFactor(90);

            entity.Property(e => e.iddespachoitem).IsFixedLength();
        });

        modelBuilder.Entity<paise>(entity =>
        {
            entity.HasKey(e => e.idpais).HasFillFactor(90);
        });

        modelBuilder.Entity<pedidodecompra>(entity =>
        {
            entity.HasKey(e => e.idpedidodecompra)
                .HasName("PK__pedidode__2160DB100880433F")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<pedidodecompraitem>(entity =>
        {
            entity.HasKey(e => e.idpedidodecompraitem).HasFillFactor(90);
        });

        modelBuilder.Entity<perfile>(entity =>
        {
            entity.HasKey(e => e.id_perfil).HasName("PK__perfiles__1D1C87680A537D18");
        });

        modelBuilder.Entity<planillatraslado>(entity =>
        {
            entity.HasKey(e => e.idplanillatraslado)
                .HasName("PK_planillatraslado_1")
                .HasFillFactor(90);

            entity.Property(e => e.nroenvio).HasDefaultValue(0);
        });

        modelBuilder.Entity<planillatrasladoitem>(entity =>
        {
            entity.HasKey(e => e.idplanillatrasladoitems)
                .HasName("PK_planillatraslado")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<preferenciaarancelarium>(entity =>
        {
            entity.HasKey(e => e.idpreferencia).HasFillFactor(90);
        });

        modelBuilder.Entity<productosimpo>(entity =>
        {
            entity.HasKey(e => e.idproductoimpo)
                .HasName("PK_catalogoproductos")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<programador>(entity =>
        {
            entity.HasKey(e => e.iddo)
                .HasName("PK__programa__9DB7AA9E0C50D423")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<programadordetallecontenedor>(entity =>
        {
            entity.HasKey(e => e.idprogramadordetallecontenedor)
                .HasName("PK__programa__4CD7FEA92057CCD0")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<promediodemora>(entity =>
        {
            entity.HasKey(e => e.idpromediodemoras)
                .HasName("PK__promedio__BCAAFF582D9CB955")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<proveedore>(entity =>
        {
            entity.HasKey(e => e.idproveedor).HasFillFactor(90);
        });

        modelBuilder.Entity<puertoembarque>(entity =>
        {
            entity.HasKey(e => e.idpuertoembarque).HasFillFactor(90);
        });

        modelBuilder.Entity<regimenaduanero>(entity =>
        {
            entity.HasKey(e => e.idregimenaduanero).HasFillFactor(90);
        });

        modelBuilder.Entity<regimenprecedente>(entity =>
        {
            entity.HasKey(e => e.idregimenprecedente).HasFillFactor(90);
        });

        modelBuilder.Entity<regionprocedencium>(entity =>
        {
            entity.HasKey(e => e.idregionprocedencia).HasFillFactor(90);
        });

        modelBuilder.Entity<seguimientodespacho>(entity =>
        {
            entity.HasKey(e => e.idseguimientodespacho)
                .HasName("PK__seguimie__ADB663D86B99EBCE")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<sistemasEspCatalogoP>(entity =>
        {
            entity.HasKey(e => e.idsistemasEspCatalogoP)
                .HasName("PK_idsistemasEspCatalogoP")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<sistemasespeciale>(entity =>
        {
            entity.HasKey(e => e.idsistemaespecial).HasFillFactor(90);
        });

        modelBuilder.Entity<solicitudclientedato>(entity =>
        {
            entity.HasKey(e => e.iddatossolicitudcliente).HasFillFactor(90);
        });

        modelBuilder.Entity<subpartida>(entity =>
        {
            entity.HasKey(e => e.idsubpartida).HasFillFactor(90);
        });

        modelBuilder.Entity<tbCiudad>(entity =>
        {
            entity.HasKey(e => e.CCodigoCiudad).HasFillFactor(90);
        });

        modelBuilder.Entity<tbDeclaracionExportacion>(entity =>
        {
            entity.HasKey(e => e.nIdConsecutivo)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.nIdConsecutivo).HasComment("consecutivo de la declaracion");
            entity.Property(e => e.CNombreDeclarante)
                .HasDefaultValue("")
                .HasComment("Apellidos y nombres de quien suscribe el documento");
            entity.Property(e => e.cAnno)
                .HasDefaultValue("")
                .HasComment("Año del aoperación");
            entity.Property(e => e.cAutoActa)
                .HasDefaultValue("")
                .HasComment("Auto y Acta ");
            entity.Property(e => e.cAutohadesivoImportacionAnterior)
                .HasDefaultValue("")
                .HasComment("Autohadesivo Declaración de Importación anterior");
            entity.Property(e => e.cAutorizacionEmbarque)
                .HasDefaultValue("")
                .HasComment("Autorización de embarque");
            entity.Property(e => e.cCertificadoOrigen)
                .HasDefaultValue("")
                .HasComment("Certificado de origen");
            entity.Property(e => e.cCiudadPaisDestino)
                .HasDefaultValue("")
                .HasComment("Ciudad del pais de destino");
            entity.Property(e => e.cClaseExportador)
                .HasDefaultValue("")
                .HasComment("Clase de exportador");
            entity.Property(e => e.cCod)
                .HasDefaultValue("")
                .HasComment("Código");
            entity.Property(e => e.cCodAdmonCertificacion)
                .HasDefaultValue("")
                .HasComment("Código Administración Certificación");
            entity.Property(e => e.cCodAdmonExportador)
                .HasDefaultValue("")
                .HasComment("Código Admon");
            entity.Property(e => e.cCodDatos)
                .HasDefaultValue("")
                .HasComment("Código datos");
            entity.Property(e => e.cCodDptoExportador)
                .HasDefaultValue("")
                .HasComment("Cod. Dpto ");
            entity.Property(e => e.cCodDptoProcedencia)
                .HasDefaultValue("")
                .HasComment("Cod. dpto. procedencia");
            entity.Property(e => e.cCodEmbarque)
                .HasDefaultValue("")
                .HasComment("Código embarque");
            entity.Property(e => e.cCodFormaPago)
                .HasDefaultValue("")
                .HasComment("Código forma de pago");
            entity.Property(e => e.cCodLugarSalida)
                .HasDefaultValue("")
                .HasComment("Código lugar de salida");
            entity.Property(e => e.cCodModalidadImportacion)
                .HasDefaultValue("")
                .HasComment("Cod. Modalidad Importación");
            entity.Property(e => e.cCodMunicipioExportador)
                .HasDefaultValue("")
                .HasComment("Cod. Municipio ");
            entity.Property(e => e.cCodOficIndustriaTurismo)
                .HasDefaultValue("")
                .HasComment("Cod Ofic. Regional Mincomercio Industria y Turismo ");
            entity.Property(e => e.cCodPaisDestino)
                .HasDefaultValue("")
                .HasComment("Cod. Pais Destino");
            entity.Property(e => e.cCodigoAdmonEmbarque)
                .HasDefaultValue("")
                .HasComment("Código Admon. de Embarque");
            entity.Property(e => e.cCodigoBandera)
                .HasDefaultValue("")
                .HasComment("Código bandera");
            entity.Property(e => e.cCodigoDeclarante)
                .HasDefaultValue("")
                .HasComment("Código declarante");
            entity.Property(e => e.cCodigoExportacionTransito)
                .HasDefaultValue("")
                .HasComment("Código exportación en tránsito");
            entity.Property(e => e.cCodigoLocalizacionMercancia)
                .HasDefaultValue("")
                .HasComment("Código localización mercancía");
            entity.Property(e => e.cCodigoModalidad)
                .HasDefaultValue("")
                .HasComment("Código modalidad");
            entity.Property(e => e.cCodigoModoTransporte)
                .HasDefaultValue("")
                .HasComment("Código modo de transporte");
            entity.Property(e => e.cCodigoMonedaNegociacion)
                .HasDefaultValue("")
                .HasComment("Código moneda de negociación ");
            entity.Property(e => e.cConsolidacion)
                .HasDefaultValue("")
                .HasComment("Consolidación");
            entity.Property(e => e.cDVDeclarante)
                .HasDefaultValue("")
                .HasComment("Digito verificación del Nit de Mario Londoño");
            entity.Property(e => e.cDVExportador)
                .HasDefaultValue("")
                .HasComment("Digito de chequeo del exportador");
            entity.Property(e => e.cDeclaracionExportacionAnterior)
                .HasDefaultValue("")
                .HasComment("Declaración exportación anterior");
            entity.Property(e => e.cDeclaracionExportacionDefinitiva)
                .HasDefaultValue("")
                .HasComment("Número Declaración de exportación definitiva");
            entity.Property(e => e.cDireccionDestino)
                .HasDefaultValue("")
                .HasComment("Dirección pais de destino");
            entity.Property(e => e.cDireccionExportador)
                .HasDefaultValue("")
                .HasComment("Dirección del exportador");
            entity.Property(e => e.cDocumentoDeclarante)
                .HasDefaultValue("")
                .HasComment("Documento de identificación empleado Mario Londoño");
            entity.Property(e => e.cEmbalajes)
                .HasDefaultValue("")
                .HasComment("Códigos Embalajes");
            entity.Property(e => e.cFechaAutohadesivoImportacionAnterior)
                .HasDefaultValue("")
                .HasComment("Fecha Autohadesivo Declaración de Importación anterior");
            entity.Property(e => e.cFechaEmbarque)
                .HasDefaultValue("")
                .HasComment("Fecha de embarque");
            entity.Property(e => e.cFechaExportacionAnterior)
                .HasDefaultValue("")
                .HasComment("Fecha exportación anterior");
            entity.Property(e => e.cFechaExportacionDefinitiva)
                .HasDefaultValue("")
                .HasComment("Fecha Declaración de exportación definitiva");
            entity.Property(e => e.cFechaManifiestoCarga)
                .HasDefaultValue("")
                .HasComment("Fecha Manifiesto de Carga");
            entity.Property(e => e.cFechaPrimerPagoAnticipado)
                .HasDefaultValue("")
                .HasComment("Fecha primer pago anticipado");
            entity.Property(e => e.cFechaProcedeEmbarque)
                .HasDefaultValue("")
                .HasComment("Fecha Procede el Embaque? Embarque Directo ");
            entity.Property(e => e.cIdentificacionFirma)
                .HasDefaultValue("")
                .HasComment("Identificación del que firma");
            entity.Property(e => e.cIdentificacionInspector).HasComment("Identificacón inspector");
            entity.Property(e => e.cIdentificacionMedioTransporte)
                .HasDefaultValue("")
                .HasComment("Identificacion del medio de transporte");
            entity.Property(e => e.cMarcarsYNumeros)
                .HasDefaultValue("")
                .HasComment("Marcas y números");
            entity.Property(e => e.cNitDeclarante)
                .HasDefaultValue("")
                .HasComment("Nit de Mario Londoño ");
            entity.Property(e => e.cNitExportador)
                .HasDefaultValue("")
                .HasComment("Nit del exportador");
            entity.Property(e => e.cNombre)
                .HasDefaultValue("")
                .HasComment("Nombre del que firma");
            entity.Property(e => e.cNombreArchivoFuente)
                .HasDefaultValue("")
                .HasComment("Nombre del archivo fuente");
            entity.Property(e => e.cNombreInspector).HasComment("Nombre inspector");
            entity.Property(e => e.cNroManifiestoCarga)
                .HasDefaultValue("")
                .HasComment("Número Manifiesto de Carga");
            entity.Property(e => e.cNumeroFormulario)
                .HasDefaultValue("")
                .HasComment("Número de formulario ");
            entity.Property(e => e.cObservaciones)
                .HasDefaultValue("")
                .HasComment("Observaciones");
            entity.Property(e => e.cProcedeEmbarque)
                .HasDefaultValue("")
                .HasComment("Procede el Embaque? Embarque Directo ");
            entity.Property(e => e.cRazonSocialExportador)
                .HasDefaultValue("")
                .HasComment("Apellidos y nombres o Razon Social del exportador");
            entity.Property(e => e.cRazonSocialImportador)
                .HasDefaultValue("")
                .HasComment("Nombre o razón social importador o consignatario");
            entity.Property(e => e.cRazonSocilaDeclarante)
                .HasDefaultValue("")
                .HasComment("Apellidos y nombres o Razon Social del declarante autorizado");
            entity.Property(e => e.cSistemasEspeciales)
                .HasDefaultValue("")
                .HasComment("Sistemas especiales");
            entity.Property(e => e.cTelefonoExportador)
                .HasDefaultValue("")
                .HasComment("Teléfono del exportador");
            entity.Property(e => e.cTipoDeclaracion)
                .HasDefaultValue("")
                .HasComment("Tipo declaración");
            entity.Property(e => e.cTipoUsuarioDeclarante)
                .HasDefaultValue("")
                .HasComment("Tipo de Usuario");
            entity.Property(e => e.cVistoBuenoEntidad01)
                .HasDefaultValue("")
                .HasComment("Visto bueno entidad");
            entity.Property(e => e.cVistoBuenoEntidad02)
                .HasDefaultValue("")
                .HasComment("Visto bueno entidad");
            entity.Property(e => e.nCantidad)
                .HasDefaultValueSql("((0))")
                .HasComment("Cantidad");
            entity.Property(e => e.nCantidadEmbarques)
                .HasDefaultValue((short)0)
                .HasComment("Cantidad de Embarques");
            entity.Property(e => e.nCantidadPagosAnticipados)
                .HasDefaultValue((short)0)
                .HasComment("Cantidad de pagos anticipados");
            entity.Property(e => e.nConsDo)
                .HasDefaultValue(0L)
                .HasComment("consecutivo del do");
            entity.Property(e => e.nDocumento)
                .HasDefaultValue((short)0)
                .HasComment("Código del documento según tabla tbDocumento");
            entity.Property(e => e.nNroBultos)
                .HasDefaultValueSql("((0))")
                .HasComment("No. Bultos ");
            entity.Property(e => e.nPesoBrutoKgs)
                .HasDefaultValue(0m)
                .HasComment("Peso bruto kgs");
            entity.Property(e => e.nPesoKgr)
                .HasDefaultValueSql("((0))")
                .HasComment("Peso(Kgr)");
            entity.Property(e => e.nTotalPesoNetoKgs)
                .HasDefaultValue(0m)
                .HasComment("Total Peso neto Kgs");
            entity.Property(e => e.nTotalValorAgregadoNal)
                .HasDefaultValue(0m)
                .HasComment("Total Valor Agregado Nal. USD");
            entity.Property(e => e.nTotalValorFOB)
                .HasDefaultValue(0m)
                .HasComment("Total Valor FOB ");
            entity.Property(e => e.nUltimo)
                .HasDefaultValue(true)
                .HasComment("Si tiene 1 es el ultimo archivo subido para la operación o DO ");
            entity.Property(e => e.nValorAReintegrar)
                .HasDefaultValue(0m)
                .HasComment("Valor a reintegrar USD");
            entity.Property(e => e.nValorFletes)
                .HasDefaultValue(0m)
                .HasComment("Valor fletes USD");
            entity.Property(e => e.nValorOtrosGastos)
                .HasDefaultValue(0m)
                .HasComment(" Valor otros gastos USD");
            entity.Property(e => e.nValorSeguros)
                .HasDefaultValue(0m)
                .HasComment("Valor seguros USD");
            entity.Property(e => e.nValorTotalExportacion)
                .HasDefaultValue(0m)
                .HasComment("Valor total de la exportación USD");
            entity.Property(e => e.nValorTotalMonedaNegociacion)
                .HasDefaultValue(0m)
                .HasComment("Valor total en moneda de negociación");
        });

        modelBuilder.Entity<tbDepartamento>(entity =>
        {
            entity.HasKey(e => e.CCodigoDepartamento).HasFillFactor(90);

            entity.Property(e => e.CNombreDepartamento).HasDefaultValue("");
        });

        modelBuilder.Entity<tbEntregaMciaExpo>(entity =>
        {
            entity.HasKey(e => new { e.idPedido, e.idEntrega }).HasFillFactor(90);

            entity.Property(e => e.idEntrega).ValueGeneratedOnAdd();
            entity.Property(e => e.cAuxiliarPedido).HasDefaultValue("");
            entity.Property(e => e.cBl).HasDefaultValue("");
            entity.Property(e => e.cCondicionesPago).HasDefaultValue("");
            entity.Property(e => e.cDeclaracion).HasDefaultValue("");
            entity.Property(e => e.cDivision).HasDefaultValue("");
            entity.Property(e => e.cDo).HasDefaultValue("");
            entity.Property(e => e.cFactura).HasDefaultValue("");
            entity.Property(e => e.cObservaciones).HasDefaultValue("");
            entity.Property(e => e.cRegistro).HasDefaultValue("");
            entity.Property(e => e.cRegistroImportacion).HasDefaultValue("");
            entity.Property(e => e.idComprador).HasDefaultValue(0);
            entity.Property(e => e.idTransporte).HasDefaultValue(0);
            entity.Property(e => e.idaduana).HasDefaultValue(0);
            entity.Property(e => e.idincoterm).HasDefaultValue(0);
            entity.Property(e => e.idmoneda).HasDefaultValue(0);
            entity.Property(e => e.nPesoBruto).HasDefaultValue(0m);
            entity.Property(e => e.nPesoNeto).HasDefaultValue(0m);
            entity.Property(e => e.nTasa).HasDefaultValue(0m);
            entity.Property(e => e.nValorFactura).HasDefaultValue(0m);
            entity.Property(e => e.nValorFob).HasDefaultValue(0m);
            entity.Property(e => e.trm).HasDefaultValue(0m);
        });

        modelBuilder.Entity<tbEntregaMciaItemExpo>(entity =>
        {
            entity.HasKey(e => new { e.idPedido, e.idPedidodecompraitem, e.idEntrega, e.idEntregaItem }).HasFillFactor(90);

            entity.Property(e => e.idEntregaItem).ValueGeneratedOnAdd();
            entity.Property(e => e.nCantidadEntregada).HasDefaultValue(0m);
        });

        modelBuilder.Entity<tbEntregaMcium>(entity =>
        {
            entity.HasKey(e => e.idEntrega)
                .HasName("PK_tbEntregaMcia_1")
                .HasFillFactor(90);

            entity.Property(e => e.cAuxiliarOrden).HasDefaultValue("");
            entity.Property(e => e.cBl).HasDefaultValue("");
            entity.Property(e => e.cCondicionesPago).HasDefaultValue("");
            entity.Property(e => e.cDeclaracion).HasDefaultValue("");
            entity.Property(e => e.cDivision).HasDefaultValue("");
            entity.Property(e => e.cDo).HasDefaultValue("");
            entity.Property(e => e.cFactura).HasDefaultValue("");
            entity.Property(e => e.cObservaciones).HasDefaultValue("");
            entity.Property(e => e.cRegistro).HasDefaultValue("");
            entity.Property(e => e.cRegistroImportacion).HasDefaultValue("");
            entity.Property(e => e.idaduana).HasDefaultValue(0);
            entity.Property(e => e.idincoterm).HasDefaultValue(0);
            entity.Property(e => e.idmoneda).HasDefaultValue(0);
            entity.Property(e => e.idproveedor).HasDefaultValue(0);
            entity.Property(e => e.idvia).HasDefaultValue(0);
            entity.Property(e => e.nPesoBruto).HasDefaultValue(0m);
            entity.Property(e => e.nPesoNeto).HasDefaultValue(0m);
            entity.Property(e => e.nTasa).HasDefaultValue(0m);
            entity.Property(e => e.nValorFactura).HasDefaultValue(0m);
            entity.Property(e => e.nValorFob).HasDefaultValue(0m);
            entity.Property(e => e.trm).HasDefaultValue(0m);
        });

        modelBuilder.Entity<tbRegistro>(entity =>
        {
            entity.HasKey(e => e.IdRegistro).HasFillFactor(90);

            entity.Property(e => e.Auxiliar).HasDefaultValue("");
            entity.Property(e => e.FechaAux).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdAduana).HasDefaultValue(0);
            entity.Property(e => e.IdCarpeta).HasDefaultValue(0);
            entity.Property(e => e.IdImportador).HasDefaultValue(0);
            entity.Property(e => e.IdProveedor).HasDefaultValue(0);
            entity.Property(e => e.Numero).HasDefaultValue(0);
            entity.Property(e => e.Trm).HasDefaultValue(0m);
            entity.Property(e => e.nDescuentosDistDolar).HasDefaultValue(0m);
            entity.Property(e => e.nDescuentosDolar).HasDefaultValue(0m);
            entity.Property(e => e.nFletesDistDolar).HasDefaultValue(0m);
            entity.Property(e => e.nFletesDolar).HasDefaultValue(0m);
            entity.Property(e => e.nGastosDistDolar).HasDefaultValue(0m);
            entity.Property(e => e.nGastosDolar).HasDefaultValue(0m);
            entity.Property(e => e.nOtrosDistDolar).HasDefaultValue(0m);
            entity.Property(e => e.nOtrosDolar).HasDefaultValue(0m);
            entity.Property(e => e.nSeguroDistDolar).HasDefaultValue(0m);
            entity.Property(e => e.nSeguroDolar).HasDefaultValue(0m);
        });

        modelBuilder.Entity<tbRegistrosItem>(entity =>
        {
            entity.HasKey(e => new { e.IdRegistroItem, e.IdRegistro }).HasFillFactor(90);

            entity.Property(e => e.IdRegistroItem).ValueGeneratedOnAdd();
            entity.Property(e => e.Cantidad).HasDefaultValue(0m);
            entity.Property(e => e.Item).HasDefaultValue(0);
            entity.Property(e => e.Peso).HasDefaultValue(0m);
            entity.Property(e => e.ValorUnitario).HasDefaultValue(0m);
            entity.Property(e => e.idInsumo).HasDefaultValue(0);
            entity.Property(e => e.nCantidadDeclarada).HasDefaultValue(0m);
            entity.Property(e => e.sticker).HasDefaultValue("");
        });

        modelBuilder.Entity<tb_ActividadEconomicaRut>(entity =>
        {
            entity.HasKey(e => e.idActividad).HasName("PK__tb_Activ__327F9BED3508D0F3");
        });

        modelBuilder.Entity<tb_CaracteristicasxGastosPropio>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tb_Carac__3213E83F38D961D7");

            entity.HasOne(d => d.idServicioNavigation).WithMany(p => p.tb_CaracteristicasxGastosPropios)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__tb_Caract__idSer__15B0212B");
        });

        modelBuilder.Entity<tb_ConcecutivoDO>(entity =>
        {
            entity.HasKey(e => e.idConcecutivo).HasName("PK__tb_Conce__ADFFDA1D3CA9F2BB");
        });

        modelBuilder.Entity<tb_ConsecutivoDTum>(entity =>
        {
            entity.HasKey(e => e.concecutivo).HasName("PK__tb_Conse__A34DE22A407A839F");
        });

        modelBuilder.Entity<tb_DTum>(entity =>
        {
            entity.HasKey(e => e.IdDTA).HasName("PK__tb_DTA__0E662DF84CA06362");
        });

        modelBuilder.Entity<tb_DetalleDTum>(entity =>
        {
            entity.HasKey(e => e.IdDTADetalle).HasName("PK__tb_Detal__9D62E9C15BE2A6F2");
        });

        modelBuilder.Entity<tb_NegociacionxEmpresa>(entity =>
        {
            entity.HasKey(e => e.idNegociacion).HasName("PK__tb_Negoc__405AB23A4DD47EBD");
        });

        modelBuilder.Entity<tb_RepresentanteTransportador>(entity =>
        {
            entity.HasKey(e => e.idRepresentante).HasName("PK__tb_Repre__119773E35575A085");
        });

        modelBuilder.Entity<tb_TarifarioPortuario>(entity =>
        {
            entity.HasKey(e => e.IdTarifarioPort).HasName("PK__tb_Tarif__3342AA055D16C24D");
        });

        modelBuilder.Entity<tb_TransitoAduanero>(entity =>
        {
            entity.HasKey(e => e.idTrancito).HasName("PK__tb_Trans__21A6627B66A02C87");
        });

        modelBuilder.Entity<tb_TransitoAduaneroDetalle>(entity =>
        {
            entity.HasKey(e => e.idDetalleTransito).HasName("PK__tb_Trans__DA4A15496A70BD6B");
        });

        modelBuilder.Entity<tb_XMLGenerado>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tb_XMLGe__3213E83F6E414E4F");
        });

        modelBuilder.Entity<tb_liquidacionAnticipo>(entity =>
        {
            entity.HasKey(e => e.idliquidacionAnt).HasName("PK__tb_liqui__42BCF40746335CF5");
        });

        modelBuilder.Entity<tb_perfilesxusuario>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tb_perfi__3213E83F51A50FA1");
        });

        modelBuilder.Entity<tb_tarifarioPortDetalle>(entity =>
        {
            entity.HasKey(e => e.IdTarifarioDetalle).HasName("PK__tb_tarif__423508A359463169");

            entity.HasOne(d => d.IdTarifarioPortNavigation).WithMany(p => p.tb_tarifarioPortDetalles).HasConstraintName("FK__tb_tarifa__IdTar__16A44564");
        });

        modelBuilder.Entity<tb_tempProductoImpo>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tb_tempP__3213E83F62CF9BA3");
        });

        modelBuilder.Entity<tiempoliberacion>(entity =>
        {
            entity.ToView("tiempoliberacion");
        });

        modelBuilder.Entity<tiempovaciado>(entity =>
        {
            entity.ToView("tiempovaciado");
        });

        modelBuilder.Entity<tipocarga>(entity =>
        {
            entity.HasKey(e => e.idtipocarga).HasFillFactor(90);
        });

        modelBuilder.Entity<tipodato>(entity =>
        {
            entity.HasKey(e => e.idtipodatos).HasFillFactor(90);
        });

        modelBuilder.Entity<tipodeoperacion>(entity =>
        {
            entity.HasKey(e => e.idtipodeoperacion).HasFillFactor(90);
        });

        modelBuilder.Entity<tipodocumentosoporte>(entity =>
        {
            entity.HasKey(e => e.idtipodocumentosoporte).HasFillFactor(90);
        });

        modelBuilder.Entity<tipoembarque>(entity =>
        {
            entity.HasKey(e => e.idtipoembarque).HasFillFactor(90);
        });

        modelBuilder.Entity<tiposolicitud>(entity =>
        {
            entity.HasKey(e => e.idtiposolicitud).HasFillFactor(90);
        });

        modelBuilder.Entity<transferenciaCuentum>(entity =>
        {
            entity.HasKey(e => e.idtransferencia).HasName("PK__transfer__10F096461A1FD08D");
        });

        modelBuilder.Entity<transportador>(entity =>
        {
            entity.HasKey(e => e.idtransportador).HasFillFactor(90);
        });

        modelBuilder.Entity<trazabilidad_logistica>(entity =>
        {
            entity.ToView("trazabilidad_logistica");

            entity.Property(e => e.Entrega_de_la_mercancia_para_embarque).IsFixedLength();
            entity.Property(e => e.Fecha_BL_Guia).IsFixedLength();
            entity.Property(e => e.Fecha_Devolucion_Contenedor).IsFixedLength();
            entity.Property(e => e.Fecha_Documentos_Transportador).IsFixedLength();
            entity.Property(e => e.Fecha_Estimada_de_Arribo).IsFixedLength();
            entity.Property(e => e.Fecha_Estimada_de_Zarpe).IsFixedLength();
            entity.Property(e => e.Fecha_Estimada_de_entrega_Proveedor).IsFixedLength();
            entity.Property(e => e.Fecha_Factura).IsFixedLength();
            entity.Property(e => e.Fecha_Levante).IsFixedLength();
            entity.Property(e => e.Fecha_Orden).IsFixedLength();
            entity.Property(e => e.Fecha_Real_Motonave).IsFixedLength();
            entity.Property(e => e.Fecha_de_Envío_de_Originales).IsFixedLength();
            entity.Property(e => e.Fecha_entrega_del_proveedor).IsFixedLength();
            entity.Property(e => e.Llegada_de_la_mercancía_a_Destino_Nacional).IsFixedLength();
            entity.Property(e => e.Recepción_Documentos_Originales).IsFixedLength();
        });

        modelBuilder.Entity<unidadcomercial>(entity =>
        {
            entity.HasKey(e => e.idunidadcomercial).HasFillFactor(90);
        });

        modelBuilder.Entity<unidaddian>(entity =>
        {
            entity.HasKey(e => e.idunidaddian).HasFillFactor(90);
        });

        modelBuilder.Entity<unidade>(entity =>
        {
            entity.HasKey(e => e.idunidad).HasFillFactor(90);
        });

        modelBuilder.Entity<unidadmedidaplazo>(entity =>
        {
            entity.HasKey(e => e.idunidadmedidaplazo).HasFillFactor(90);
        });

        modelBuilder.Entity<usuario>(entity =>
        {
            entity.HasKey(e => e.idusuario)
                .HasName("PK_Usuarios")
                .HasFillFactor(90);

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Digitador).HasDefaultValue(false);
            entity.Property(e => e.DigitadorRevisor).HasDefaultValue(false);
            entity.Property(e => e.Revisor).HasDefaultValue(false);
            entity.Property(e => e.ultimasincronizacion).IsFixedLength();
        });

        modelBuilder.Entity<usuariosU>(entity =>
        {
            entity.HasKey(e => e.idusuario).HasFillFactor(90);
        });

        modelBuilder.Entity<vPlaneador>(entity =>
        {
            entity.ToView("vPlaneador");

            entity.Property(e => e.fechaconfirmacionpedido).IsFixedLength();
            entity.Property(e => e.fechadoc).IsFixedLength();
            entity.Property(e => e.fechaentrega).IsFixedLength();
            entity.Property(e => e.fechaguia).IsFixedLength();
            entity.Property(e => e.fechallegada).IsFixedLength();
            entity.Property(e => e.fechaprogramadacargue).IsFixedLength();
            entity.Property(e => e.fechaprometidaproduccion).IsFixedLength();
            entity.Property(e => e.fecharequeridacliente).IsFixedLength();
            entity.Property(e => e.fechasolicitudexportacion).IsFixedLength();
            entity.Property(e => e.fechazarpe).IsFixedLength();
        });

        modelBuilder.Entity<vPlaneadorExportacione>(entity =>
        {
            entity.ToView("vPlaneadorExportaciones");
        });

        modelBuilder.Entity<v_Documento>(entity =>
        {
            entity.ToView("v_Documento");

            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<v_Impresora>(entity =>
        {
            entity.ToView("v_Impresora");

            entity.Property(e => e.id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<v_Variable>(entity =>
        {
            entity.ToView("v_Variable");
        });

        modelBuilder.Entity<v_documentodetalle>(entity =>
        {
            entity.ToView("v_documentodetalle");

            entity.Property(e => e.idDocumentoDetalle).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<v_variableDocumentoImpresoraDetalle>(entity =>
        {
            entity.ToView("v_variableDocumentoImpresoraDetalle");
        });

        modelBuilder.Entity<variableDocumentoImpresora>(entity =>
        {
            entity.HasIndex(e => new { e.idDocumento, e.idImpresora }, "IX_variableDocumentoImpresora")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasComment("Número unico que identifica la variable para una impresora y documento especificos");
            entity.Property(e => e.idDocumento).HasComment("Número unico que identifica al documento");
            entity.Property(e => e.idImpresora).HasComment("Número unico que identifica la impresora");

            entity.HasOne(d => d.idDocumentoNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_variableDocumentoImpresora_documento");
        });

        modelBuilder.Entity<variableDocumentoImpresoraDetalle>(entity =>
        {
            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasComment("Número unico que identifica el detalle para una impresora y documento especificos dentro la tabla variableDocumentoImpresora");
            entity.Property(e => e.idDocumentoDetalle).HasComment("Identificador del registro dentro de la tabla de documento detalle");
            entity.Property(e => e.idVariableDocumentoImpresora).HasComment("Número unico que identifica la variable para una impresora y documento especificos dentro la tabla variableDocumentoImpresora");
            entity.Property(e => e.nombreCampo).HasComment("Nombre del campo, el cual va contener la información extraida de la BD y el procedimiento almacenado relacionado en tabla docuemto");
            entity.Property(e => e.nombreVariable).HasComment("Nombre de la etiqueta imprimir que tiene el documento o formulario");
            entity.Property(e => e.numeroVariable).HasComment("Número de la posición de la variable en documento o formulario");
            entity.Property(e => e.posicionX).HasComment("Distancia en milimitros para el eje X de la variable");
            entity.Property(e => e.posicionY).HasComment("Distancia en milimitros para el eje Y de la variable");

            entity.HasOne(d => d.idDocumentoDetalleNavigation).WithMany().HasConstraintName("FK_variableDocumentoImpresoraDetalle_documentoDetalle");
        });

        modelBuilder.Entity<via>(entity =>
        {
            entity.HasKey(e => e.idvia).HasFillFactor(90);
        });

        modelBuilder.Entity<vistosbuenositem>(entity =>
        {
            entity.HasKey(e => e.idvistobuenoitem).HasFillFactor(90);
        });

        modelBuilder.Entity<zonafranca>(entity =>
        {
            entity.HasKey(e => e.idzonafranca).HasFillFactor(90);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
