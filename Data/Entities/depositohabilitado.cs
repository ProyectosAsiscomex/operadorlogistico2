using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("depositohabilitado")]
public partial class depositohabilitado
{
    [Key]
    public int iddepositohabilitado { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idaduana { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tipo { get; set; }
}
