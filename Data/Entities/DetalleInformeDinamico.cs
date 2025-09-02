using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleInformeDinamico")]
public partial class DetalleInformeDinamico
{
    [Key]
    public int idtabladetalleinformedinamico { get; set; }

    public int? idtablainformedinamico { get; set; }

    [StringLength(500)]
    public string? nombreoriginalcampo { get; set; }

    [StringLength(500)]
    public string? titulocampo { get; set; }

    public string? descripcioncampo { get; set; }

    [StringLength(50)]
    public string? tipocampo { get; set; }
}
