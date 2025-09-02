using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DIANCIP")]
public partial class DIANCIP
{
    [Key]
    public int idcip { get; set; }

    [StringLength(50)]
    public string? numero { get; set; }
}
