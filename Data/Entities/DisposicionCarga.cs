using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DisposicionCarga")]
public partial class DisposicionCarga
{
    [Key]
    public int iddisposicioncarga { get; set; }

    public int? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
