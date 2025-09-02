using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("programador")]
public partial class programador
{
    [Key]
    public int iddo { get; set; }

    public int? idpedido { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fechacreacion { get; set; }

    public int? idexportador { get; set; }

    public int? iddestinatario { get; set; }

    public int? idtransportadornacional { get; set; }

    public int? idembarcador { get; set; }

    public int? idnaviera { get; set; }

    public int? idtipocarga { get; set; }

    public int? idunidadcarga { get; set; }

    public int? idtamanocontenedor { get; set; }

    public int? idmodotransporte { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? mercapeligrosa { get; set; }

    public int? idmoneda { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    public int? iddeclarante { get; set; }

    public int? idtipoequipo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? booking { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrocontenedor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? motonave { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? viaje { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? emisionbl { get; set; }

    public int? idlugarembarque { get; set; }

    public int? idlugardestino { get; set; }

    public int? cmbidpais { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idlugarcargue { get; set; }

    public int? idaduana { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? certificadoorigen { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaprogramadacargue { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? etaptodestino { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? etaptoorigen { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? cierrefisico { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? cierredocumental { get; set; }

    public int? idvia { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? fletes { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sistemasespeciales { get; set; }

    public int? idincoterm { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? lugardestino { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? aerolinea { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechingpuerto { get; set; }

    public int? tipodocumento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? numdoc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadoc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? tracker { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaguia { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacruce { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechazarpe { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechanetrega { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? rollover { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nuevamotonave { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? nuevaetaori { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? nuevaetades { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechallegada { get; set; }

    public int? idtransportadorinternacional { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigoimo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? dexdefinitivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadexdefinitivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ncierrefisico { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDocumentoCompletos { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaGeneracionSae { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaPlanilla { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaBorrador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaAprobacion { get; set; }
}
