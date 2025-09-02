using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_LiquidacionLCL")]
public partial class tb_LiquidacionLCL
{
    [Key]
    public int idLiquidacion { get; set; }

    public int? idPuertoEmbarque { get; set; }

    public int? idPuertoDestino { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? PesoBruto { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? VolumenM3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OCPedido { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? modulo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TipoEnvio { get; set; }
}
