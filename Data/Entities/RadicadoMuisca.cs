using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RadicadoMuisca")]
public partial class RadicadoMuisca
{
    [Key]
    public int idRadicadoMuisca { get; set; }

    public int? idAutorizacionEmbarque { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroSae { get; set; }

    public bool? Exitoso { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Error { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? RutaPdf { get; set; }
}
