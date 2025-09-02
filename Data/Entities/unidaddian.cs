using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("unidaddian")]
public partial class unidaddian
{
    [Key]
    public int idunidaddian { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(20)]
    public string? nombre { get; set; }

    [StringLength(10)]
    public string? abreviatura { get; set; }
}
