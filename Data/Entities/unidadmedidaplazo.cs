using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("unidadmedidaplazo")]
public partial class unidadmedidaplazo
{
    [Key]
    public int idunidadmedidaplazo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? descripcion { get; set; }
}
