using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Categoria
{
    [Key]
    public int idCategoria { get; set; }

    [StringLength(300)]
    public string? nombre { get; set; }

    public int? idincoterm { get; set; }

    public int? nIdRegion { get; set; }

    [StringLength(100)]
    public string? tipo { get; set; }
}
