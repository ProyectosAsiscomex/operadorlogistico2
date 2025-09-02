using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("ConsecutivoCotizacion")]
public partial class ConsecutivoCotizacion
{
    public long idConsecutivo { get; set; }

    public int? idEmpresa { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Consecutivo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? formulario { get; set; }
}
