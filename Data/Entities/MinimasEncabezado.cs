using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("MinimasEncabezado")]
public partial class MinimasEncabezado
{
    [Key]
    public int idarancel { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? capitulo { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subpartida { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? arancelarmonico { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? nacional1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? nacional2 { get; set; }

    [StringLength(3000)]
    public string? descripcion { get; set; }

    public bool? subidatemporal { get; set; }
}
