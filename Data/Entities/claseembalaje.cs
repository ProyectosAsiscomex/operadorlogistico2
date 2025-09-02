using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("claseembalaje")]
public partial class claseembalaje
{
    [Key]
    public int idembalaje { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
