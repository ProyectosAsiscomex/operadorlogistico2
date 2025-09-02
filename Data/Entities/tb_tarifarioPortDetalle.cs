using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_tarifarioPortDetalle")]
public partial class tb_tarifarioPortDetalle
{
    [Key]
    public int IdTarifarioDetalle { get; set; }

    public int? IdTarifarioPort { get; set; }

    public int? IdGasto { get; set; }

    public int? idMoneda { get; set; }

    public int? idtamano { get; set; }

    public int? idtipoequipo { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Valortarifa { get; set; }

    public bool? AplicaRangos { get; set; }

    public int? RangoInicial { get; set; }

    public int? RangoFinal { get; set; }

    [ForeignKey("IdTarifarioPort")]
    [InverseProperty("tb_tarifarioPortDetalles")]
    public virtual tb_TarifarioPortuario? IdTarifarioPortNavigation { get; set; }
}
