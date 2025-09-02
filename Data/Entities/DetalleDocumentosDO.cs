using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleDocumentosDO")]
public partial class DetalleDocumentosDO
{
    [Key]
    public int IddetalleDoc { get; set; }

    public int? IdDO { get; set; }

    [StringLength(50)]
    public string? tipo { get; set; }

    public int? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaExpedicion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }

    [Column(TypeName = "money")]
    public decimal? Valor { get; set; }

    public int? Items { get; set; }

    public bool? original { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? fletes { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? seguros { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? otrosGastos { get; set; }
}
