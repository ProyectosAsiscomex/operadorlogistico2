using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class descripcionsubpartida
{
    [Key]
    public int idsubpartida { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? subpartida { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }
}
