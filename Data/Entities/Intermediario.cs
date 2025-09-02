using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Intermediario
{
    [Key]
    public int idintermediario { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? razonsocial { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? segundoapellido { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? otrosnombres { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    public int? idcodpais { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? idcodtipointermediario { get; set; }
}
