using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_TarifarioPortuario")]
public partial class tb_TarifarioPortuario
{
    [Key]
    public int IdTarifarioPort { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Modalidad { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }

    public int? idLugarPuerto { get; set; }

    public int? idTipoCarga { get; set; }

    public int? idVia { get; set; }

    [InverseProperty("IdTarifarioPortNavigation")]
    public virtual ICollection<tb_tarifarioPortDetalle> tb_tarifarioPortDetalles { get; set; } = new List<tb_tarifarioPortDetalle>();
}
