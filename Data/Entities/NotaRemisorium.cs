using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class NotaRemisorium
{
    [Key]
    public int idnotaremisoria { get; set; }

    public int? idexportador { get; set; }

    public int? iddeclaimpo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nronacionalizacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechanotaremisoria { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaliberaciondocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaentregadocumento { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? idbl { get; set; }

    [Column(TypeName = "money")]
    public decimal? valormercancia { get; set; }

    public int? idtransportadornacional { get; set; }

    public int? idconsignatario { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? deposito { get; set; }

    public int? idremite { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaseguimiento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaentregaplanillas { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharetirorealpuerto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechallegadadestino { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    [StringLength(4000)]
    public string? nroformulario { get; set; }

    [StringLength(500)]
    public string? destino { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharetirocargasuelta { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? prioridad { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Modalidad { get; set; }

    public int? idasignacionitr { get; set; }

    public int? idproveedor { get; set; }

    public int? idcomprador { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? mercancia { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorFOBUSD { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorAsegurado { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Arancel { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? IVA { get; set; }

    public int? iddeclarante { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? eta { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? llegadaReal { get; set; }

    public int? PlanillaDepositoOrig { get; set; }

    public int? PlanillaDepositoCopia { get; set; }

    public int? DocumentoTransporteOrig { get; set; }

    public int? DocumentoTransporteCopia { get; set; }

    public int? ComodatoOrig { get; set; }

    public int? ComodatoCopia { get; set; }

    public int? PazySalvoOrig { get; set; }

    public int? PazySalvoCopia { get; set; }

    public int? OtrodocumentoOrig { get; set; }

    public int? OtrodocumentoCopia { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Cual { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Contacto { get; set; }
}
