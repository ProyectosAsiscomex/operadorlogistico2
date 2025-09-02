using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[PrimaryKey("idPedido", "idEntrega")]
[Table("tbEntregaMciaExpo")]
public partial class tbEntregaMciaExpo
{
    [Key]
    public int idPedido { get; set; }

    [Key]
    public int idEntrega { get; set; }

    [StringLength(20)]
    public string cAuxiliarPedido { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaAuxiliar { get; set; }

    public int? idComprador { get; set; }

    public int? idaduana { get; set; }

    public int? idincoterm { get; set; }

    public int? idmoneda { get; set; }

    [Column(TypeName = "money")]
    public decimal? trm { get; set; }

    [StringLength(20)]
    public string? cRegistroImportacion { get; set; }

    public int? idTransporte { get; set; }

    [Column(TypeName = "money")]
    public decimal? nTasa { get; set; }

    [StringLength(50)]
    public string? cFactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaFactura { get; set; }

    [Column(TypeName = "money")]
    public decimal? nValorFactura { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? nPesoBruto { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? nPesoNeto { get; set; }

    [StringLength(20)]
    public string? cBl { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaBl { get; set; }

    [StringLength(20)]
    public string? cDo { get; set; }

    [StringLength(20)]
    public string? cRegistro { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaAprobacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? nValorFob { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaVencimiento { get; set; }

    [StringLength(20)]
    public string? cDeclaracion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaDeclaracion { get; set; }

    [StringLength(50)]
    public string? cDivision { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaLlegada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fFechaNacionalizacion { get; set; }

    public int? idDestinoFinal { get; set; }

    public int? idBanco { get; set; }

    [StringLength(100)]
    public string? cCondicionesPago { get; set; }

    public int? idlugarembarque { get; set; }

    public int? idEmbarcador { get; set; }

    [StringLength(2000)]
    public string? cObservaciones { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? auxiliar { get; set; }
}
