using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class subpartida
{
    [Key]
    public int idsubpartida { get; set; }

    [Column("subpartida")]
    [StringLength(20)]
    public string? subpartida1 { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }

    public int idunidaddian { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? arancel { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? iva { get; set; }

    [StringLength(10)]
    public string? COMPLEMENTARIO { get; set; }

    [StringLength(10)]
    public string? SUPLEMENTARIO { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? DIFERENCIAL { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? VIGENCIA { get; set; }

    [Unicode(false)]
    public string? OBSERVACIONES { get; set; }

    public int? idunidadvuce { get; set; }

    public bool? habilitado { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? desgravacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadesgravacion { get; set; }

    public bool? mixtopeso { get; set; }

    public bool? mixtopares { get; set; }
}
