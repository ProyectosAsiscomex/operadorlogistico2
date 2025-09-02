using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("IdentificacionONU")]
public partial class IdentificacionONU
{
    [Key]
    public int ididentificaciononu { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }

    [StringLength(500)]
    public string? nombre { get; set; }
}
