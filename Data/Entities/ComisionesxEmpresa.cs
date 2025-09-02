using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ComisionesxEmpresa")]
public partial class ComisionesxEmpresa
{
    [Key]
    public int idcomisionxempresa { get; set; }

    public short? tipocomision { get; set; }

    [Column(TypeName = "money")]
    public decimal? valortope { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorminimo { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? por1 { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? por2 { get; set; }

    public int? idexportador { get; set; }

    public int? idcompania { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? idtipo { get; set; }
}
