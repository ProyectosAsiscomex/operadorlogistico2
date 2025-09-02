using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class DocumentosDemora
{
    [StringLength(50)]
    [Unicode(false)]
    public string? nrodo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nodocumento { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nomanifiesto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nocontenedores { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainiciodemoras { get; set; }
}
