using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Registro")]
public partial class Registro
{
    [Key]
    public int idregistro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
