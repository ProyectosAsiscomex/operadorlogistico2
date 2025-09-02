using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class instruccione
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainforme { get; set; }

    [Key]
    public int idinstrucciones { get; set; }

    public int? idpedido { get; set; }

    public int? idexportador { get; set; }

    [StringLength(1000)]
    public string? descripcion { get; set; }

    public int? idunidadcarga { get; set; }

    public int? idtransportador { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? kgs { get; set; }

    public int? idtamano { get; set; }

    public int? idtipoequipo { get; set; }

    public int? idaduana { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? eta { get; set; }

    [StringLength(1000)]
    public string? idciudad { get; set; }

    [StringLength(1000)]
    public string? lugardescargue { get; set; }

    public string? observaciones { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidad { get; set; }

    [StringLength(500)]
    public string? nrocontenedor { get; set; }

    public bool? desconsolida { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidadgeneral { get; set; }

    public int? idunidadcarga2 { get; set; }

    public int? idnaviera { get; set; }

    public int? idembarcador { get; set; }

    public bool? descargue { get; set; }
}
