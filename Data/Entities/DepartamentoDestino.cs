using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("DepartamentoDestino")]
public partial class DepartamentoDestino
{
    public int iddepartamento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? descripcion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
