using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SeguimientoItem")]
public partial class SeguimientoItem
{
    [Key]
    public int idSeguimientoItem { get; set; }

    public int? idSeguimiento { get; set; }

    public int? idDO { get; set; }

    [StringLength(500)]
    public string? estado { get; set; }

    public int? idEstado { get; set; }

    [StringLength(20)]
    public string? Semaforo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public bool? publico { get; set; }

    public int? orden { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechainicial { get; set; }

    public int? idexportador { get; set; }

    public int? idmovimiento { get; set; }

    [StringLength(500)]
    public string? presencia { get; set; }

    public int? idcategoria { get; set; }

    public int? idcategoriaitem { get; set; }

    public bool? actualizadoSP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaDocumento { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? agrupacion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? hora { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? horafinal { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechallegada { get; set; }

    public bool? itemEliminado { get; set; }
}
