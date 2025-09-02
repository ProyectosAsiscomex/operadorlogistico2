using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class TarifarioItem
{
    [Key]
    public int idTarifarioItem { get; set; }

    public int? idtarifario { get; set; }

    public int? Idtamanocontenedor { get; set; }

    public int? Idtipoequipo { get; set; }

    [Column(TypeName = "money")]
    public decimal? tarifaflete { get; set; }

    [Column(TypeName = "money")]
    public decimal? tarifaminima { get; set; }

    [Column(TypeName = "money")]
    public decimal? BAF { get; set; }

    [Column(TypeName = "money")]
    public decimal? GRIGRR { get; set; }

    [Column(TypeName = "money")]
    public decimal? IMO { get; set; }

    [Column(TypeName = "money")]
    public decimal? PORTSECURITY { get; set; }

    [Column(TypeName = "money")]
    public decimal? usodeinstalaciones { get; set; }

    [Column(TypeName = "money")]
    public decimal? RecargosAdicionales { get; set; }

    [Column(TypeName = "money")]
    public decimal? emisionblusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? consolidacionusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? bodegajesusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? manejos { get; set; }

    [Column(TypeName = "money")]
    public decimal? stickerpeligrosousd { get; set; }

    [Column(TypeName = "money")]
    public decimal? GastosOrigen { get; set; }

    [Column(TypeName = "money")]
    public decimal? Gastosendestino { get; set; }

    [Column(TypeName = "money")]
    public decimal? Inland { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAllIN { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAllINgastos { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? observacionestarifa { get; set; }

    [Column(TypeName = "money")]
    public decimal? desconsolidacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalCargoIMO { get; set; }

    [Column(TypeName = "money")]
    public decimal? ConsolidacionMinima { get; set; }

    [Column(TypeName = "money")]
    public decimal? TarifaMounting { get; set; }

    [Column(TypeName = "money")]
    public decimal? MountingMinima { get; set; }

    [Column(TypeName = "money")]
    public decimal? ConsolidacionMinimaImpo { get; set; }

    [Column(TypeName = "money")]
    public decimal? TarifaForwardingFee { get; set; }

    [Column(TypeName = "money")]
    public decimal? ForwardingFeeMinima { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasaOrigen { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasDestino { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalCop { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? OtrosGastos { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasaOtrosGastos { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalOtrosGastos { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalFlete { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TasaFlete { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? Volumen { get; set; }

    public int? NroContenedor { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? PesoNeto { get; set; }

    [Unicode(false)]
    public string? Tipo { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PesoCargable { get; set; }
}
