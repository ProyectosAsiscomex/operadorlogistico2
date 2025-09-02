using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Listaempaque")]
public partial class Listaempaque
{
    [Key]
    public int idlistaempaque { get; set; }

    public int? idexportador { get; set; }

    public int? idcomprador { get; set; }

    public int? iddeclarante { get; set; }

    [StringLength(50)]
    public string? nroListaempaque { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? total { get; set; }

    [StringLength(50)]
    public string? nropedido { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaListaempaque { get; set; }

    public int? idtransportador { get; set; }
}
