using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("Temporalvistosbuenosxsubp")]
public partial class Temporalvistosbuenosxsubp
{
    public double? ID_VISTO_SUBPARTIDA { get; set; }

    public double? ID_VISTO_BUENO { get; set; }

    [StringLength(255)]
    public string? CODIGO_POSICION { get; set; }

    [StringLength(255)]
    public string? CODIGO_ENTIDAD { get; set; }

    [StringLength(255)]
    public string? NOMBRE_ENTIDAD { get; set; }

    public int? idsubpartida { get; set; }

    public int? idvistobueno { get; set; }
}
