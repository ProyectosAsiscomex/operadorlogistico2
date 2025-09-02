using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AgendarCitum
{
    [Key]
    public int idagendarcita { get; set; }

    public int? idcliente { get; set; }

    public bool? clienteactual { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechayhora { get; set; }

    public int? idvendedor { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    public bool? citacumplida { get; set; }

    public int? idempresa { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(1000)]
    public string? Cotizacion { get; set; }

    [StringLength(1000)]
    public string? Asesoria { get; set; }

    [StringLength(1000)]
    public string? Auditoria { get; set; }

    [StringLength(1000)]
    public string? Compromisos { get; set; }

    [StringLength(1000)]
    public string? TemasTratados { get; set; }

    [StringLength(1000)]
    public string? Causas { get; set; }

    public bool? FechaCambiada { get; set; }

    public int? ClientePotencial { get; set; }
}
