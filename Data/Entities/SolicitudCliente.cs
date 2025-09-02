using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SolicitudCliente")]
public partial class SolicitudCliente
{
    [Key]
    public int idSolicitudCliente { get; set; }

    public int? idexportador { get; set; }

    public int? iddestinatario { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nroformulario { get; set; }

    public int? idregionprocedencia { get; set; }

    public int? idnaturalezatransaccion { get; set; }

    public int? idincoterm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? lugarentrega { get; set; }

    public int? idmoneda { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tasacambio { get; set; }

    public int? idformapago { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cantidadpagosanticipados { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaprimerpagoanti { get; set; }

    public bool? sistemasespeciales { get; set; }

    public int? idmodotransporte { get; set; }

    public int? idtipocarga { get; set; }

    public int? idpais { get; set; }

    public int? idlugardestino { get; set; }

    public int? idtransportador { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechageneracion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UltimaModificacion { get; set; }

    [StringLength(50)]
    public string? OrigenSolcliente { get; set; }

    public int? iddo { get; set; }

    public int? idfactura { get; set; }
}
