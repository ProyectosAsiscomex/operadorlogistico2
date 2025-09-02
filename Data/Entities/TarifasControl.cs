using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TarifasControl")]
public partial class TarifasControl
{
    public double? ccodi { get; set; }

    public double? item { get; set; }

    public bool cero { get; set; }

    public double? minimo { get; set; }

    public double? porcentaje { get; set; }

    public double? min_otrasc { get; set; }

    public double? min_porcc { get; set; }

    [StringLength(255)]
    public string? nom_usu { get; set; }

    [StringLength(255)]
    public string? fecha_usu { get; set; }

    [StringLength(255)]
    public string? hora_usu { get; set; }

    public double? icodi { get; set; }

    [StringLength(255)]
    public string? inomb { get; set; }

    public bool imp { get; set; }

    public bool exp { get; set; }

    public bool dta { get; set; }

    public bool vucefuce { get; set; }

    [StringLength(255)]
    public string? grupo_tipo { get; set; }

    [StringLength(255)]
    public string? grupo_liqu { get; set; }
}
