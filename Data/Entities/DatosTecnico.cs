using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class DatosTecnico
{
    [Key]
    public int iddatotecnico { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }
}
