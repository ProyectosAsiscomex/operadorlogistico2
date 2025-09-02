using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("InformeDinamico")]
public partial class InformeDinamico
{
    [Key]
    public int idtablainformedinamico { get; set; }

    [StringLength(500)]
    public string? nombreoriginaltabla { get; set; }

    [StringLength(500)]
    public string? titulotabla { get; set; }

    public string? descripciontabla { get; set; }

    public bool? movimiento { get; set; }
}
