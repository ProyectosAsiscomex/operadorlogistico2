using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class via
{
    [Key]
    public int idvia { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }

    [StringLength(50)]
    public string? descripcion { get; set; }
}
