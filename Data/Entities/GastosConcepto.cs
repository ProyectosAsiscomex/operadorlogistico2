using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class GastosConcepto
{
    [Key]
    public int idGastoConcepto { get; set; }

    [StringLength(200)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idtipo { get; set; }
}
