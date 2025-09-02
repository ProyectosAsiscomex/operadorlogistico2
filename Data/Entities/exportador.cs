using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("exportador")]
public partial class exportador
{
    [Key]
    public int idexportador { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tipodocumento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    public bool? diplomatico { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? dv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? segundoapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? otrosnombres { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? razonsocial { get; set; }

    [StringLength(10)]
    public string? programamp { get; set; }

    [StringLength(200)]
    public string? direccion { get; set; }

    [StringLength(20)]
    public string telefono { get; set; } = null!;

    [StringLength(2)]
    public string? claseexportador { get; set; }

    [StringLength(10)]
    public string? mpdirecto { get; set; }

    [StringLength(5)]
    public string? idciudad { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? representantelegal { get; set; }

    [StringLength(2)]
    public string? iddepartamento { get; set; }

    [StringLength(50)]
    public string? correo { get; set; }

    public int? idaduana { get; set; }

    [StringLength(3)]
    public string? CAE { get; set; }

    [StringLength(10)]
    public string? cia { get; set; }

    public bool? entidadimporta { get; set; }

    public bool? auditar { get; set; }

    public bool? habilitado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? imagen { get; set; }

    public bool? habilitarexpo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? contacto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechaexpedicion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechavencimiento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVencimientoMandato { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaMandato { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CodigoUAP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResolucionFact { get; set; }

    public bool? habilitarfecha { get; set; }

    public bool? constMinimas { get; set; }

    public bool? saeCatalogo { get; set; }

    public bool? sinresolucionfacturacion { get; set; }

    public bool? generarSAEsinVFMT { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? referenciadopor { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? nombrecomercial { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codcontable { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? claveweb { get; set; }

    public bool? asignarcotizacionesmadres { get; set; }

    public int? pais { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ciudadde { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? zonasector { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? asesorvendedor { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? celular { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fax { get; set; }

    public int? actividadEconomica { get; set; }

    public int? codigoactividadeconomica { get; set; }

    public int? nroCuenta { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? tipo { get; set; }

    public int? banco { get; set; }

    public int? nit { get; set; }

    public int? solicito { get; set; }

    public int? aprobo { get; set; }

    public int? modifico { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? titulodesignación { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cedula { get; set; }

    public int? codigorepresentacion { get; set; }

    public int? expedidaen { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? emalInstitucional { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? escriturapublica { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? camaradecomerciode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nivelComercial { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? cual { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? primerapellidorev { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? segundoapellidorev { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? primernombrerev { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? segundonombrerev { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tarjetaprofesional { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? primerapellidocont { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? segundoapellidocont { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? primernombrecont { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? segundonombrecont { get; set; }

    public bool? rut { get; set; }

    public bool? identificacionempresarial { get; set; }

    public int? cartede { get; set; }

    public bool? envioFotocopias { get; set; }

    public bool? cuentasspecial { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porimportacionseguro { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porexportacionseguro { get; set; }

    public bool? anticipoimportacion { get; set; }

    public bool? anticipoexportacion { get; set; }

    public bool? transitosaduanero { get; set; }

    public int? formaPagoimpuestos { get; set; }

    public bool? anticipoParagastos { get; set; }

    public bool? anticipoparaimpuestos { get; set; }

    [Unicode(false)]
    public string? observacionesdelanegociacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cedularev { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cedulacont { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? tarjetaprofesionalrev { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? tarjetaprofesionalcont { get; set; }

    public bool? grancontribuyente { get; set; }

    public bool? autoretenedor { get; set; }

    public bool? regimencomun { get; set; }

    public bool? esproveedorci { get; set; }

    public bool? aplicagravamenfinanciero { get; set; }

    public bool? exentodereteley { get; set; }

    public bool? facturariva { get; set; }

    public bool? exigirfacturamovimientoDO { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? porretefuente { get; set; }

    [Column("base", TypeName = "decimal(18, 2)")]
    public decimal? _base { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? porReteivaesp { get; set; }

    public int? diasvencimiento { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? interDiasVencimiento { get; set; }

    public int? codigo { get; set; }

    public bool? uuariozonafranca { get; set; }

    public bool? nocontribucionesxmil { get; set; }

    public int? nogeneracxp { get; set; }

    public int? proveedordirecto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? basediasvencimineto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? reteica { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? modificoparatributarios { get; set; }

    public int? idciudadgenerodo { get; set; }

    public int? tipodocumentorep { get; set; }

    public int? clase { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? otronivelcomercial { get; set; }

    public bool? importaciones { get; set; }

    public bool? exportaciones { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? fromaPago { get; set; }

    public int? carteraDe { get; set; }

    [Unicode(false)]
    public string? BD { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? aduanero { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? actividaddelimportador { get; set; }

    [Column(TypeName = "decimal(5, 3)")]
    public decimal? seguro { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Logo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SIGLA { get; set; }

    public bool? oCircularA { get; set; }

    public bool? oCircularNA { get; set; }

    public bool? oAcuerdoSeguridadA { get; set; }

    public bool? oAcuerdoSeguridadNA { get; set; }

    public bool? oVistaSeguridadA { get; set; }

    public bool? oVistaSeguridadNA { get; set; }

    public bool? oDeclaracionOrigenFA { get; set; }

    public bool? oDeclaracionOrigenFNA { get; set; }

    public bool? oRegistroClienteA { get; set; }

    public bool? oRegistroClienteNA { get; set; }

    public bool? oCamaraComercioA { get; set; }

    public bool? oCamaraComercioNA { get; set; }

    public bool? oRutA { get; set; }

    public bool? oRutNA { get; set; }

    public bool? oCrepresentanteA { get; set; }

    public bool? oCrepresentanteNA { get; set; }

    public bool? oReferenciaBancA { get; set; }

    public bool? oReferenciaBancNA { get; set; }

    public bool? oreferenciaComerA { get; set; }

    public bool? oreferenciaComerNA { get; set; }

    public bool? enviarcorreo { get; set; }

    public bool? bloqueado { get; set; }

    [Column(TypeName = "decimal(5, 3)")]
    public decimal? porrteiva { get; set; }

    public bool? bitreteiva { get; set; }

    public int? IdAsesorComercial { get; set; }

    public int? IdOperativo { get; set; }

    public bool oRegisClienteA { get; set; }

    public bool oRegisclienteNA { get; set; }

    [StringLength(250)]
    public string nrodocumentoRegiscliente { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaRegiscliente { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoRegiscliente { get; set; }

    [StringLength(250)]
    public string nrodocumentoCamaraComercio { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCamaraComercio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoCamaraComercio { get; set; }

    [StringLength(250)]
    public string nrodocumentoRut { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaRut { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoRut { get; set; }

    [StringLength(250)]
    public string nrodocumentoCrepresentante { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCrepresentante { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoCrepresentante { get; set; }

    public bool oEstadoA { get; set; }

    public bool oEstadoNA { get; set; }

    [StringLength(250)]
    public string nrodocumentoEstado { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaEstado { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoEstado { get; set; }

    public bool oEstudioA { get; set; }

    public bool oEstudioNA { get; set; }

    [StringLength(250)]
    public string nrodocumentoEstudio { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaEstudio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoEstudio { get; set; }

    [StringLength(250)]
    public string nrodocumentoreferenciaComer { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechareferenciaComer { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoreferenciaComer { get; set; }

    [StringLength(250)]
    public string nrodocumentoReferenciaBanc { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaReferenciaBanc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoReferenciaBanc { get; set; }

    [StringLength(250)]
    public string nrodocumentoSeguridad { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaSeguridad { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoSeguridad { get; set; }

    [StringLength(250)]
    public string nrodocumentoVistaSeguridad { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaVistaSeguridad { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoVistaSeguridad { get; set; }

    [StringLength(250)]
    public string nrodocumentoCircular { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCircular { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? validoCircular { get; set; }

    [InverseProperty("idClienteNavigation")]
    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    [InverseProperty("Exportador")]
    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();

    [InverseProperty("idClienteNavigation")]
    public virtual ICollection<ReciboCajaAnticipo> ReciboCajaAnticipos { get; set; } = new List<ReciboCajaAnticipo>();

    [InverseProperty("idClienteNavigation")]
    public virtual ICollection<ReciboCajaMenor> ReciboCajaMenors { get; set; } = new List<ReciboCajaMenor>();
}
