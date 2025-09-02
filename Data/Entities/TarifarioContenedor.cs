using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TarifarioContenedor")]
public partial class TarifarioContenedor
{
    [Key]
    public int idTarifarioContenedor { get; set; }

    public int? idcarpeta { get; set; }

    public int? idnaviera { get; set; }

    public int? idagencia { get; set; }

    public int? idcontrolador { get; set; }

    public int? idembarcador { get; set; }

    public int? idpuertodestino { get; set; }

    [StringLength(100)]
    public string? liberacion { get; set; }

    [StringLength(100)]
    public string? deposito { get; set; }

    public int? idmoneda { get; set; }

    public int? idlugardestino { get; set; }

    public int? idpaisdestino { get; set; }
}
