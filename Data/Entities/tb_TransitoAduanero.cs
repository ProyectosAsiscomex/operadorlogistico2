using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_TransitoAduanero")]
public partial class tb_TransitoAduanero
{
    [Key]
    public int idTrancito { get; set; }

    public bool? Tipo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DO { get; set; }

    public int? Destinatario { get; set; }

    public int? Declarante { get; set; }

    public int? Transportador { get; set; }

    public int? Aduanadepartida { get; set; }

    public int? AduanadeDestino { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Manifiestodecarga { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechadellegada { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Documentodetransporte { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDocumentoTransporte { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IdentifMedioTransporte { get; set; }

    public int? RazonSocialDeposito { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? ValorFOBUSD { get; set; }

    public int? Paisdecompra { get; set; }
}
