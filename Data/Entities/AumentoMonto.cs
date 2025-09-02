using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AumentoMonto
{
    [Key]
    public int idAumento { get; set; }

    public int? iddo { get; set; }

    public int? idusuario { get; set; }

    [StringLength(10)]
    public string? valor { get; set; }
}
