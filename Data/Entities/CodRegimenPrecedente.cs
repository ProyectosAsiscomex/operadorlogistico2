using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CodRegimenPrecedente")]
public partial class CodRegimenPrecedente
{
    [Key]
    [StringLength(4)]
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }
}
