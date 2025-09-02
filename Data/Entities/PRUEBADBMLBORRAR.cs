using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("PRUEBADBMLBORRAR")]
public partial class PRUEBADBMLBORRAR
{
    [Key]
    [StringLength(10)]
    public string iddbml { get; set; } = null!;

    [StringLength(10)]
    public string? sdfsdf { get; set; }
}
