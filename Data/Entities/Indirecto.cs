using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Indirecto
{
    [Key]
    public int idindirecto { get; set; }

    public int? idexportador { get; set; }

    [StringLength(10)]
    public string? mpindirecto { get; set; }
}
