using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ConsecutivoFactCiudad")]
public partial class ConsecutivoFactCiudad
{
    [Key]
    public int idConsecutivo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    public bool? Estado { get; set; }

    public long? ConsecutivoInicial { get; set; }

    public long? ConsecutivoFinal { get; set; }

    public long? ProximaFactura { get; set; }

    public int? idlugaringresomercancias { get; set; }
}
