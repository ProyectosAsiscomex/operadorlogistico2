using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("InstruccionesDetalle")]
public partial class InstruccionesDetalle
{
    [Key]
    public int idinstruccionesdetalle { get; set; }

    public int? idinstrucciones { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidadadespachar { get; set; }

    public int? idunidadcarga { get; set; }

    [StringLength(500)]
    public string? destino { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idciudad { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? cantidad { get; set; }
}
