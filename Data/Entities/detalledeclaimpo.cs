using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("detalledeclaimpo")]
public partial class detalledeclaimpo
{
    [Key]
    public int iddetalledeclaimpo { get; set; }

    public int? iddeclaimpo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? marca { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? referencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? seriales { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? numeros { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? cantidad { get; set; }

    public int? idordendecompraitem { get; set; }

    public int? iddetallefacturaimportacion { get; set; }
}
