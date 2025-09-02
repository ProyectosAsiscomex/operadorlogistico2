using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TarifarioContenedoritem")]
public partial class TarifarioContenedoritem
{
    [Key]
    public int idTarifarioContenedoritem { get; set; }

    public int? idTarifarioContenedor { get; set; }

    public int? idtipoequipo { get; set; }

    public int? diaslibres { get; set; }

    [Column(TypeName = "money")]
    public decimal? valordiademora { get; set; }

    [Column(TypeName = "money")]
    public decimal? Dropoff { get; set; }

    public int? idtamanocontenedor { get; set; }

    public int? idmonedaitem { get; set; }

    public int? idmonedadrop { get; set; }
}
