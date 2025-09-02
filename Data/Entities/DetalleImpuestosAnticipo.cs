using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleImpuestosAnticipo")]
public partial class DetalleImpuestosAnticipo
{
    [Key]
    public int idDetalleImpuestosAnticipo { get; set; }

    public int? idAnticipo { get; set; }

    public int? idSubpartida { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Arancel { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Iva { get; set; }

    public int? idModalidad { get; set; }

    public int? idPaisOrigen { get; set; }

    public int? idAcuerdoComercial { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorFob { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CorreoEnviado { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? UsuarioEnvio { get; set; }

    public bool deposito { get; set; }

    [StringLength(20)]
    public string NroDO { get; set; } = null!;
}
