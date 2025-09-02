using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class IdentificacionRiesgo
{
    [Key]
    public int ididentificacionriesgos { get; set; }

    [StringLength(100)]
    public string? codigo { get; set; }

    public string? nombre { get; set; }
}
