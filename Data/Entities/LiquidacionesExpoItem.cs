using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LiquidacionesExpoItem")]
public partial class LiquidacionesExpoItem
{
    [Key]
    public int idLiquidacionExpoItem { get; set; }

    public int? idRelacionGastos { get; set; }

    public int? idDo { get; set; }

    public int? idMovimiento { get; set; }

    public int? idGasto { get; set; }

    public int? idMoneda { get; set; }

    [Column(TypeName = "money")]
    public decimal? Tasa { get; set; }

    [Column(TypeName = "money")]
    public decimal? Trm { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Cantidad { get; set; }

    public int? idliquidacion { get; set; }

    public bool? Documento { get; set; }

    [StringLength(100)]
    public string? Presencia { get; set; }

    public string? Observaciones { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    public bool? Bloqueado { get; set; }

    [StringLength(50)]
    public string? NroContenedor { get; set; }

    [StringLength(200)]
    public string? nrofactura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafactura { get; set; }

    public int? idtercero { get; set; }

    [Column(TypeName = "money")]
    public decimal? iva { get; set; }

    public int? servicioaduana { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? valorreal { get; set; }

    public int? idempresa { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? UsuarioUltimaModificacion { get; set; }
}
