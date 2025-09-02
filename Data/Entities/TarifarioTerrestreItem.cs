using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TarifarioTerrestreItem")]
public partial class TarifarioTerrestreItem
{
    [Key]
    public int idTarifarioterrestreItem { get; set; }

    public int? idtipocontenedor { get; set; }

    public int? idtipoequipo { get; set; }

    public int? rangoinicial { get; set; }

    public int? rangofinal { get; set; }

    [Column(TypeName = "money")]
    public decimal? Tarifa { get; set; }

    public int? idunidad { get; set; }

    [StringLength(20)]
    public string? tipocarga { get; set; }

    public int? idtarifarioterrestre { get; set; }

    [StringLength(30)]
    public string? tipovehiculo { get; set; }

    [Column(TypeName = "money")]
    public decimal? devolucion { get; set; }
}
