using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("comisionesxempresadetalle")]
public partial class comisionesxempresadetalle
{
    [Key]
    public int idcomisiondetalle { get; set; }

    public int? idcomisionxempresa { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? rangoinicial { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? rangofinal { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? porcomi { get; set; }
}
