using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AdjuntosExpo")]
public partial class AdjuntosExpo
{
    [Key]
    public int idAdjuntoexpo { get; set; }

    public int? iddocumento { get; set; }

    [StringLength(200)]
    public string? descripcion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(400)]
    public string? ruta { get; set; }

    public int? idautorizacionembarque { get; set; }

    public int? idpedido { get; set; }

    [StringLength(500)]
    public string? comentario { get; set; }

    public int? idexportador { get; set; }
}
