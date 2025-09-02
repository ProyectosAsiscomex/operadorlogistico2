using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_liquidacionAnticipo")]
public partial class tb_liquidacionAnticipo
{
    [Key]
    public int idliquidacionAnt { get; set; }

    public int? IdDO { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NroPedidoOC { get; set; }

    public int? IdImportador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaAnticipo { get; set; }

    public int? IdVia { get; set; }

    public int? idMoneda { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? Tasa { get; set; }

    [Column(TypeName = "money")]
    public decimal? TRM { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorFOB { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorFletes { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorSeguros { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorOtrosGastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorAjustes { get; set; }

    [Column(TypeName = "money")]
    public decimal? Salvaguardia { get; set; }

    [Column(TypeName = "money")]
    public decimal? Compensatorios { get; set; }

    [Column(TypeName = "money")]
    public decimal? Antidumping { get; set; }

    [Column(TypeName = "money")]
    public decimal? Sancion { get; set; }

    [Column(TypeName = "money")]
    public decimal? Rescate { get; set; }

    public int? idLugarPuerto { get; set; }

    public int? idTiooCarga { get; set; }

    public int? idtamano { get; set; }

    public int? idTipoEquipo { get; set; }

    public int? NroContenedores { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Volumen { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? PesoNetoKG { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? PesoBrutoKG { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaEstimadaLlegada { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaEstimadaRetiro { get; set; }
}
