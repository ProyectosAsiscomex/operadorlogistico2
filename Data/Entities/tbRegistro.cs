using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class tbRegistro
{
    [Key]
    public int IdRegistro { get; set; }

    [StringLength(20)]
    public string? Auxiliar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAux { get; set; }

    public int? Numero { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRegistro { get; set; }

    public int? IdCarpeta { get; set; }

    public int? IdImportador { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdAduana { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? Trm { get; set; }

    public int? idactividad { get; set; }

    public int? idregimen { get; set; }

    public int? idPaisOrigen { get; set; }

    public int? idVia { get; set; }

    public int? idMoneda { get; set; }

    public int? idTipoSolicitud { get; set; }

    [StringLength(200)]
    public string? Consignatario { get; set; }

    public int? idLugarEmbarque { get; set; }

    public int? idReembolzo { get; set; }

    public int? idSia { get; set; }

    [StringLength(200)]
    public string? Firmante { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nFletesDistDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nFletesDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nSeguroDistDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nSeguroDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nGastosDistDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nGastosDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nDescuentosDistDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nDescuentosDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nOtrosDistDolar { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? nOtrosDolar { get; set; }

    public int? CODIND { get; set; }
}
