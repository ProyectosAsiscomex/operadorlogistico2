using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Indicadore
{
    [Key]
    public int idIndicador { get; set; }

    [StringLength(300)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Tipo { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? sobrecostosdia { get; set; }
}
