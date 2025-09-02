using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("declarante")]
public partial class declarante
{
    [Key]
    public int iddeclarante { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tipodocumento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? dv { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? segundoapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? otrosnombres { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? razonsocial { get; set; }

    [StringLength(100)]
    public string? CodigoUsuario { get; set; }

    [StringLength(100)]
    public string? TipoUsuario { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    [StringLength(200)]
    public string? correoimportaciones { get; set; }

    [StringLength(30)]
    public string? fax { get; set; }

    [StringLength(100)]
    public string? nombreasignatario { get; set; }

    [StringLength(20)]
    public string? cedula { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? idciudad { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodGarantiaTributos { get; set; }

    public int? TipoGarantiaTributos { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoGarantiaTributos { get; set; }

    public int? ValorGarantiaTributos { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaVigencia { get; set; }
}
