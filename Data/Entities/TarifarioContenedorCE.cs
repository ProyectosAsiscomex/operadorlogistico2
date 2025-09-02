using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TarifarioContenedorCE")]
public partial class TarifarioContenedorCE
{
    [Key]
    public int idTarifarioContenedorCE { get; set; }

    public int? idTarifarioContenedoritem { get; set; }

    [Column(TypeName = "money")]
    public decimal? valordiademora { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? rangoinicio { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? rangofinal { get; set; }
}
