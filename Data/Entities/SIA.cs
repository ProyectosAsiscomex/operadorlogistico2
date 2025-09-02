using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SIAS")]
public partial class SIA
{
    [Key]
    public int idsia { get; set; }

    [StringLength(150)]
    public string? razonsocial { get; set; }

    [StringLength(100)]
    public string? telefono { get; set; }

    [StringLength(50)]
    public string? fax { get; set; }

    [StringLength(200)]
    public string? direccion { get; set; }

    [StringLength(100)]
    public string? ciudad { get; set; }

    [StringLength(100)]
    public string? email { get; set; }

    [StringLength(20)]
    public string? nit { get; set; }
}
