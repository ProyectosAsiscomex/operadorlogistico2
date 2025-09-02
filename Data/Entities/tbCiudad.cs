using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tbCiudad")]
public partial class tbCiudad
{
    [StringLength(40)]
    public string CNombreCiudad { get; set; } = null!;

    [Key]
    [StringLength(5)]
    public string CCodigoCiudad { get; set; } = null!;

    [StringLength(2)]
    public string CCodigoDepartamento { get; set; } = null!;
}
