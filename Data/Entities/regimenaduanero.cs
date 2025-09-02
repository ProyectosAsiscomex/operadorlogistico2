using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("regimenaduanero")]
public partial class regimenaduanero
{
    [Key]
    public int idregimenaduanero { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
