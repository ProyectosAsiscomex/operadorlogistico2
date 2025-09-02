using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALDESMINIMAS")]
public partial class TEMPORALDESMINIMA
{
    [Unicode(false)]
    public string? Etiqueta { get; set; }

    [Unicode(false)]
    public string? valor { get; set; }

    [Unicode(false)]
    public string? codigo { get; set; }

    public int? idproductoimpo { get; set; }

    [Unicode(false)]
    public string? referencia { get; set; }

    [Unicode(false)]
    public string? valoresfilas { get; set; }

    public int? idfila { get; set; }

    public bool? TRASLADADO { get; set; }
}
