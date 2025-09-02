using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class DetalledeDocumento
{
    [Key]
    public int iddetallededocumentos { get; set; }

    public int? idempresa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Expedicion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Validez { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Renovacion { get; set; }

    public int? idtipoDocumento { get; set; }

    public int? Cupo { get; set; }
}
