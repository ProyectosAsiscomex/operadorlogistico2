using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_RepresentanteTransportador")]
public partial class tb_RepresentanteTransportador
{
    [Key]
    public int idRepresentante { get; set; }

    public int? idTransportador { get; set; }

    public int? TipoDocumento { get; set; }

    [StringLength(509)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    public int? DV { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PrimerApellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SegundoApellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PrimeNombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OtrosNombre { get; set; }

    public bool? Habilitado { get; set; }
}
