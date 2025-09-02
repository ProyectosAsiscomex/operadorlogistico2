using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RadicadosEdiFac")]
public partial class RadicadosEdiFac
{
    [Key]
    public int idRadicadosEdiFac { get; set; }

    public int? idDeclaracion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaInicio { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaFin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Radicado { get; set; }

    [Unicode(false)]
    public string? Retorno { get; set; }

    public bool? SoporteExito { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SoporteFecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AceptacionNumero { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? AceptacionFecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LevanteNumero { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LevanteFecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LevanteEstado { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AutoadhesivoNumero { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? AutoadhesivoFecha { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ArchivoDim { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReciboOficialPago { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaReciboOficialPago { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorReciboOficialPago { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ArchivoDimSoporte { get; set; }

    [ForeignKey("idDeclaracion")]
    [InverseProperty("RadicadosEdiFacs")]
    public virtual declaracionImportacion? idDeclaracionNavigation { get; set; }
}
