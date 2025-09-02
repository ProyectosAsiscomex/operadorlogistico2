using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("IB_EMPLEADOS")]
public partial class IB_EMPLEADO
{
    public double? id_empleado { get; set; }

    [StringLength(255)]
    public string? numero_identificacion { get; set; }
}
