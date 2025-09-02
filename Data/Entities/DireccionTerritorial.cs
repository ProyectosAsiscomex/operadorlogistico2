using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DireccionTerritorial")]
public partial class DireccionTerritorial
{
    [Key]
    public int iddireccionterritorial { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombre { get; set; }
}
