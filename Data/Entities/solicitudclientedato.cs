using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class solicitudclientedato
{
    [Key]
    public int iddatossolicitudcliente { get; set; }

    public int? idsubpartidas { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? DescripcionMcia { get; set; }

    public int? idpreferenciaarancelaria { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroprograma { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? reposicion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrocip { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroproducto { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? cantidadprodexpocip { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? van { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? vie { get; set; }

    public int? idSolicitudCliente { get; set; }
}
