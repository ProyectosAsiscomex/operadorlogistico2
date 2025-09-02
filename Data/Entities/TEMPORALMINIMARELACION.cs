using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALMINIMARELACION")]
public partial class TEMPORALMINIMARELACION
{
    [StringLength(50)]
    [Unicode(false)]
    public string? SUBPARTIDA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CODIGO { get; set; }

    public int? IDARANCEL { get; set; }

    public int? IDDESCRIPCION { get; set; }
}
