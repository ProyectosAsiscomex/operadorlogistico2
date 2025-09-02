using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AdjuntosPlanvallejo")]
public partial class AdjuntosPlanvallejo
{
    [Key]
    public int idAdjunto { get; set; }

    public int? idAdjuntoAutorizacionEmbarque { get; set; }

    public int? idDocumento { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? Ruta { get; set; }
}
