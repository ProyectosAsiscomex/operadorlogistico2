using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("puertoembarque")]
public partial class puertoembarque
{
    [Key]
    public int idpuertoembarque { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigomincomex { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idpais { get; set; }
}
