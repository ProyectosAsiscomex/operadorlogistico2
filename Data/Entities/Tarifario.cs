using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Tarifario")]
public partial class Tarifario
{
    [Key]
    public int idtarifario { get; set; }

    public bool? modulo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tipoenvio { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nrocotizacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacotizacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechavigencia { get; set; }

    public int? idnaviera { get; set; }

    public int? idembarcador { get; set; }

    public int? idpuertoembarque { get; set; }

    public int? idpaispuertoembarque { get; set; }

    public int? idpuertodestino { get; set; }

    public int? idpaispuertodestino { get; set; }

    public int? idfrecuencia { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Servicio { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tiempoentransito { get; set; }

    public int? idregion { get; set; }

    public int? idtipocarga { get; set; }

    [Column(TypeName = "decimal(12, 8)")]
    public decimal? tasa { get; set; }

    public int? idmoneda { get; set; }

    public bool? Acuerdo { get; set; }

    [Unicode(false)]
    public string? observaciones { get; set; }

    public int? IdExportador { get; set; }

    [Unicode(false)]
    public string? LugarOrigenTerrestre { get; set; }

    [Unicode(false)]
    public string? LugarDestinoTerrestre { get; set; }

    public int? IdTransportadorTerrestre { get; set; }

    [Unicode(false)]
    public string? AeropuertoOrigen { get; set; }

    [Unicode(false)]
    public string? AeropuertoDestino { get; set; }

    public int? idPuertoOrigen { get; set; }

    public int? idPaisPuertoOrigen { get; set; }

    public int? IdAeroLinea { get; set; }
}
