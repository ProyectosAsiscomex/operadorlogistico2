using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class RelacionGasto
{
    [Key]
    public int idrelaciongastos { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idincoterm { get; set; }

    public bool? PredeterminadoImpo { get; set; }

    public bool? PredeterminadoExpo { get; set; }
}
