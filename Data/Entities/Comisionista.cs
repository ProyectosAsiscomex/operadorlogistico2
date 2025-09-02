using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Comisionista
{
    [Key]
    public int idcomisionista { get; set; }

    [StringLength(20)]
    public string? codigo { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }

    [StringLength(100)]
    public string? telefono { get; set; }

    [StringLength(20)]
    public string? fax { get; set; }

    [StringLength(100)]
    public string? email { get; set; }

    [StringLength(200)]
    public string? direccion { get; set; }

    [StringLength(100)]
    public string? ciudad { get; set; }

    public int? idpais { get; set; }
}
