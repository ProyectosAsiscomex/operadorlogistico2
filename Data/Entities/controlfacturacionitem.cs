using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class controlfacturacionitem
{
    [Key]
    public int iditemcontrolfacturacion { get; set; }

    public int? idcontrolfacturacion { get; set; }

    [Column(TypeName = "decimal(32, 2)")]
    public decimal? valorusd { get; set; }

    [Column(TypeName = "decimal(32, 2)")]
    public decimal? valorcop { get; set; }

    [Column(TypeName = "decimal(32, 2)")]
    public decimal? comisionusd { get; set; }

    [Column(TypeName = "decimal(32, 2)")]
    public decimal? comisioncop { get; set; }

    [StringLength(50)]
    public string? nocheque { get; set; }

    [StringLength(50)]
    public string? norecibo { get; set; }
}
