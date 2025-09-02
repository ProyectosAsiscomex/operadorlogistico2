using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class OrdenServicio
{
    [Key]
    public int idOrdenServicio { get; set; }

    public int idDO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Amovilizar20 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Amovilizar40 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? nivelReconocimiento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fechayHora { get; set; }
}
