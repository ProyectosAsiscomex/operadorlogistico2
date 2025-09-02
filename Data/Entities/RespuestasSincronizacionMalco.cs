using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RespuestasSincronizacionMalco")]
public partial class RespuestasSincronizacionMalco
{
    [Key]
    public long idRespuesta { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroOrden { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroDOMalco { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodError { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Operacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sistema { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaRespuesta { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaEnvio { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? tipoOperacion { get; set; }
}
