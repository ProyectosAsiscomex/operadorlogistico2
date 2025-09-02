using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DespachosItem")]
public partial class DespachosItem
{
    [Key]
    public int iddespachoitem { get; set; }

    public int? iddespacho { get; set; }

    public int? idorden { get; set; }

    public int? idordendecompraitem { get; set; }

    public int? idfacturaimportacion { get; set; }

    public int? iddetallefacturaimportacion { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? cantidaddespachada { get; set; }

    public int? idunidadcarga { get; set; }

    [StringLength(50)]
    public string? remesa { get; set; }

    public int? flota { get; set; }

    [StringLength(100)]
    public string? placa { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? empaques { get; set; }

    public int? idcontenedor { get; set; }

    public int? idembalaje { get; set; }

    public int? idciudadentrega { get; set; }

    [StringLength(500)]
    public string? observaciones { get; set; }
}
