using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AreasLogistica")]
public partial class AreasLogistica
{
    [Key]
    public int idarealogistica { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
