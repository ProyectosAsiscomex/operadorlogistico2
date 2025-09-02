using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Arquear")]
public partial class Arquear
{
    [Key]
    public int idArquear { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaArqueo { get; set; }

    [Column(TypeName = "money")]
    public decimal? SaldoFinal { get; set; }

    [Column(TypeName = "money")]
    public decimal? SaldoInicial { get; set; }

    public int? idciudadesaduanimex { get; set; }
}
