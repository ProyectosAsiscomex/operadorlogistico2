using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class TarifarioAdjunto
{
    [Key]
    public int idTarifarioAdjuntos { get; set; }

    public int? idtarifario { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(400)]
    public string? ruta { get; set; }

    [StringLength(500)]
    public string? comentario { get; set; }
}
