using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DO")]
public partial class DO
{
    [Key]
    public int idDO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroDO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? idAsesorComercial { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idAsesorOperativo { get; set; }

    public int? idexportador { get; set; }

    public int? iddestinatario { get; set; }

    public int? idtransportador { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroreferencia { get; set; }

    public int? idmodotransporte { get; set; }

    public int? idmoneda { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tasacambio { get; set; }

    public string? observaciones { get; set; }

    [StringLength(200)]
    public string? estado { get; set; }

    [StringLength(100)]
    public string? tipo { get; set; }

    [StringLength(100)]
    public string? sededigitadora { get; set; }

    public int? IDEMBARCADOR { get; set; }

    public int? idtransportadornacional { get; set; }

    [StringLength(100)]
    public string? factura { get; set; }

    public int? idtipocarga { get; set; }

    [StringLength(5)]
    public string? codtipounidadcarga { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidadcarga { get; set; }

    [StringLength(5)]
    public string? codtamanocontenedor { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidadcontenedor { get; set; }

    public bool? merpeligrosa { get; set; }

    public string? errores { get; set; }

    public int? unidadcantidadcarga { get; set; }

    public int? idordendecompra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DOMalco { get; set; }

    [Unicode(false)]
    public string? Causales { get; set; }

    public int? SedeComercializadora { get; set; }

    public int? SedeOperativa { get; set; }

    public int? idmodalidad { get; set; }

    public int? idContacto { get; set; }

    public int? idtercero { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Facturara { get; set; }

    public bool? FacturarDO { get; set; }

    public int? idDeclarante { get; set; }

    public int? idtramitador { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? IdtipoDeclaracion { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nropedido { get; set; }

    public bool? aplicaregistro { get; set; }

    [Unicode(false)]
    public string? documentosfaltantes { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaModificacion { get; set; }

    public int? Idincoterm { get; set; }

    public int? idDeposito { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NroGuiaBL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CertificadoOrigen { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ListaEmpaque { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? OtrosDocumentos { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Motonave { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Booking { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NroViaje { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? PesoNeto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? PesoBruto { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Volumen { get; set; }

    public int? idlistachequeoencabezado { get; set; }

    public int? idusuario { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NroManifiesto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaManifiesto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDocTransporte { get; set; }

    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(30, 4)")]
    public decimal? NroBultos { get; set; }

    public int? idAsesorInhouse { get; set; }

    public int? idRevisor { get; set; }

    public bool? enviarimport { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalanticipo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaanticipo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechasolanticipo { get; set; }

    [StringLength(50)]
    public string? horaanticipo { get; set; }

    [StringLength(50)]
    public string? horasolanticipo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaETD { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CUTOFF { get; set; }

    public bool? prorroga { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ConsecutivoCaja { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? prorrogasolicitud { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? prorrogafecharadicado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? prorroganroradicado { get; set; }

    public int? idProveedor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? regimen { get; set; }

    public int? idaduana { get; set; }

    public int? idpuertoEmbarque { get; set; }

    [StringLength(50)]
    public string? NroDoPadre { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorNacionalizar { get; set; }

    public int? idShipper { get; set; }

    [StringLength(50)]
    public string? NroCotizacion { get; set; }

    [StringLength(1000)]
    public string? TipoMercancia { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? peso { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? dimensiones { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TipoDimension { get; set; }

    [StringLength(50)]
    public string? idEmision { get; set; }

    public int? idPaisOrigen { get; set; }

    public int? idPuertoOrigen { get; set; }

    public int? idPaisDestino { get; set; }

    public int? idPuertoDestino { get; set; }

    [StringLength(1000)]
    public string? InstruccionesEspeciales { get; set; }

    public bool? seguro { get; set; }

    public int? idNaviera { get; set; }

    public int? idAgenteInternacionalOrigen { get; set; }

    public int? idAgenteInternacionalDestino { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudaOrigen { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudadDestino { get; set; }

    [StringLength(100)]
    public string? proveedorShipper { get; set; }

    [StringLength(600)]
    [Unicode(false)]
    public string? proveedor { get; set; }

    public bool? DeclaracionAnti { get; set; }

    [Unicode(false)]
    public string? FechaSolicitudTN { get; set; }

    [Unicode(false)]
    public string? FechaDeCargueTN { get; set; }

    [Unicode(false)]
    public string? FechaCargueProductoTN { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? ValorTN { get; set; }

    [Unicode(false)]
    public string? VehiculoTN { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? FleteTN { get; set; }

    [Unicode(false)]
    public string? CargueyDescargueTN { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorMercancia { get; set; }

    [Unicode(false)]
    public string? DireccionOrigen { get; set; }

    public int? IdPuertoRetiro { get; set; }

    [Unicode(false)]
    public string? DireccionDestino { get; set; }

    [Unicode(false)]
    public string? DireccionDevolucionContenedor { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Cantidad { get; set; }

    [Unicode(false)]
    public string? Cabotaje { get; set; }

    [Unicode(false)]
    public string? CiudadSalida { get; set; }

    [Unicode(false)]
    public string? DocumentoTransporte { get; set; }

    public int? IdTipoImportacion { get; set; }

    public int? IdTipoEmbarque { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PesoBrutoUnidadEmbarque { get; set; }

    [Unicode(false)]
    public string? DireccionDescargue { get; set; }

    [Unicode(false)]
    public string? HoraDescargue { get; set; }

    public int? IdTipoExportacion { get; set; }

    public int? IdAduanaSalida { get; set; }

    public int? IdPuertoSalida { get; set; }

    public int? IdTransporteNacional { get; set; }

    public int? IdTransporteNacionalTerrestre { get; set; }

    [Unicode(false)]
    public string? CompradorExterior { get; set; }

    public bool? RequiereMontaCarga { get; set; }

    public bool? RequiereEscolta { get; set; }

    public bool? AseguraCarga { get; set; }

    public bool? RequiereAduana { get; set; }

    [Unicode(false)]
    public string? Restricciones { get; set; }

    [Unicode(false)]
    public string? ObservacionesGenerales { get; set; }

    [Unicode(false)]
    public string? CondicionesCarga { get; set; }

    [Unicode(false)]
    public string? Consignee { get; set; }

    public bool? Cargue { get; set; }

    public bool? Descargue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TRM { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorMercanciaUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorMercanciaCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorFletesUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorFletesCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ArancelPorcentaje { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ArancelUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ArancelCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? IvaPorcentaje { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? IvaUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? IvaCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LucroPorcentaje { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LucroUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LucroCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? GastosPorcentaje { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? GastosUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? GastosCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SeguroPorcentaje { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SeguroUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SeguroCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorTotalUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ValorTotalCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasaSeguroPorcentaje { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasaSeguroUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasaSeguroCOP { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalPolizaUSD { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalPolizaCOP { get; set; }

    [Unicode(false)]
    public string? Origen_Direccion_Ciudad_Pais { get; set; }

    [Unicode(false)]
    public string? Destino_Direccion_Ciudad_Pais { get; set; }

    [Unicode(false)]
    public string? TipoOperacion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TarifaMinima { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? CantidadCajas { get; set; }

    [Unicode(false)]
    public string? Unidades { get; set; }

    public int? IdNavieraHeredado { get; set; }

    public bool? RegistroImportacion { get; set; }

    [Unicode(false)]
    public string? Carrier { get; set; }

    [Unicode(false)]
    public string? PuertoRetiro { get; set; }

    [Unicode(false)]
    public string? CedulaConductor { get; set; }

    [Unicode(false)]
    public string? CelularConductor { get; set; }

    [Unicode(false)]
    public string? NombreApellidoConductor { get; set; }

    [Unicode(false)]
    public string? FechaCierre { get; set; }

    [Unicode(false)]
    public string? FechaZarpe { get; set; }

    [Unicode(false)]
    public string? FechaArribo { get; set; }

    [Unicode(false)]
    public string? ValorPoliza { get; set; }

    [Unicode(false)]
    public string? RegistroImpo { get; set; }

    [Unicode(false)]
    public string? NroTarifa { get; set; }

    [Unicode(false)]
    public string? SellosPlasticos { get; set; }

    [Unicode(false)]
    public string? SellosAdheviso { get; set; }

    [Unicode(false)]
    public string? SellosBotella { get; set; }

    [Unicode(false)]
    public string? SellosGuaya { get; set; }

    public int? IdMonedaValorMercancia { get; set; }

    public int? IdAerolinea { get; set; }

    public string Observaciones_Instrucciones { get; set; } = null!;

    [InverseProperty("idDoOtroConceptoNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; } = new List<ReciboCajaAnticipo>();

    [InverseProperty("idDoNavigation")]
    public virtual ICollection<ReciboCajaMenor> ReciboCajaMenors { get; set; } = new List<ReciboCajaMenor>();
}
