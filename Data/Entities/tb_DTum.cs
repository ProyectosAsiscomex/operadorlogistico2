using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_DTA")]
public partial class tb_DTum
{
    [Key]
    public int IdDTA { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Ano { get; set; }

    public bool? Concepto { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NroFormulario { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DO { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Estado { get; set; }

    public int? Iddestinatatio { get; set; }

    public int? Iddeclarante { get; set; }

    public int? idtransportador { get; set; }

    public int? IdRepresentante { get; set; }

    public int? idAduanadepartida { get; set; }

    public int? idAduanadeDestino { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Manifiestodecarga { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechadellegada { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Documentodetransporte { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDocumentoTransporte { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IdentifMedioTransporte { get; set; }

    public int? RazonSocialDeposito { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorFOBUSD { get; set; }

    public int? IdPaisdecompra { get; set; }

    public int? Signatario { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoAceptacionSolicitud { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaAceptacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroAutorizacionModalidad { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechalimiteparaFinalizarModalidad { get; set; }

    public bool? ReconocimientoExterno { get; set; }

    public bool? Inspeccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoInspeccion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ComunicaciondelaAduana { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaComunicacion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Hora { get; set; }

    public bool? Prorroga { get; set; }

    public bool? Suspension { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActoAdministrativo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaActo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Termino { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaExpedicion { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? especifiqueBodega { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipoOperacion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? imgBarra1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? imgBarra2 { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Observaciones { get; set; }
}
