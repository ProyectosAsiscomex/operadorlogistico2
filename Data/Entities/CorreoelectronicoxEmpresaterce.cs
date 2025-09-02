using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CorreoelectronicoxEmpresaterce")]
public partial class CorreoelectronicoxEmpresaterce
{
    [Key]
    public int idCorreoxempre { get; set; }

    public int? IdArea { get; set; }

    [Unicode(false)]
    public string? CorreoElectronico { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idempresa { get; set; }
}
