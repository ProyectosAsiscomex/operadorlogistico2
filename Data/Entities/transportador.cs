using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("transportador")]
public partial class transportador
{
    [Key]
    public int idtransportador { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tipodocumento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? identificacion { get; set; }

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

    [StringLength(20)]
    public string? codigo { get; set; }

    public bool? habilitado { get; set; }

    public bool? TransitoAduanero { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CodUsuario { get; set; }

    public int? CodGarantiaporFinalizacion { get; set; }

    public int? TipoGarantia { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoGarantia { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorGarantia { get; set; }

    public bool? habilitadoexpo { get; set; }
}
