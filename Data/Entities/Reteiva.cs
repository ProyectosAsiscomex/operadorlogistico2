using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Reteiva
{
    [Key]
    public int idReteIva { get; set; }

    public int? idExportador { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? porcentaje { get; set; }
}
