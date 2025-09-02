using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TarifarioTerrestre")]
public partial class TarifarioTerrestre
{
    [Key]
    public int idTarifarioTerrestre { get; set; }

    public bool? RadioExpoImpo { get; set; }

    [StringLength(100)]
    public string? nrocontrato { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fechacontrato { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fechavencimiento { get; set; }

    public int? idproveedor { get; set; }

    [StringLength(10)]
    public string? idorigennacional { get; set; }

    [StringLength(10)]
    public string? iddestinonacional { get; set; }

    [Column(TypeName = "money")]
    public decimal? escolta { get; set; }

    public int? tipocarga { get; set; }

    public int? idempresa { get; set; }
}
