using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RelacionGastosItem")]
public partial class RelacionGastosItem
{
    [Key]
    public int idrelaciongastositem { get; set; }

    public int? idrelaciongastos { get; set; }

    [StringLength(100)]
    public string? nombregasto { get; set; }

    [StringLength(200)]
    public string? Contabilidad { get; set; }

    public int? idmoneda { get; set; }

    public bool? documento { get; set; }

    [Column(TypeName = "money")]
    public decimal? valor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? presencia { get; set; }

    public int? idgasto { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }
}
