using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("UnidadCarga")]
public partial class UnidadCarga
{
    [Key]
    public int idunidadcarga { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? codigo { get; set; }
}
