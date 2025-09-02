using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tbDepartamento")]
public partial class tbDepartamento
{
    [StringLength(40)]
    public string? CNombreDepartamento { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string CCodigoDepartamento { get; set; } = null!;
}
