using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Area
{
    [Key]
    public int idarea { get; set; }

    [StringLength(700)]
    public string? Nombre { get; set; }

    [StringLength(700)]
    public string? descripcion { get; set; }
}
