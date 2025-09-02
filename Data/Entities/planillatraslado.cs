using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("planillatraslado")]
public partial class planillatraslado
{
    [Key]
    public int idplanillatraslado { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? nroplanilla { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? concepto { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codmediotransporte { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? nroidentmediotransporte { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? nroplanillaAnterior { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? TotalNroContenedores { get; set; }

    public int? nroenvio { get; set; }
}
