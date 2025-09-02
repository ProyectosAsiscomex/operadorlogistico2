using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class acuerdo
{
    [Key]
    public int idacuerdo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? codigo_acuerdo { get; set; }

    [Unicode(false)]
    public string? nombre_acuerdo { get; set; }
}
