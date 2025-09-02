using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class ClaveRegistrada
{
    [Key]
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    [StringLength(100)]
    public string? Clave { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCambio { get; set; }
}
