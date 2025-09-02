using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("RelacionesInformeDinamico")]
public partial class RelacionesInformeDinamico
{
    [Key]
    public int idtablarelacioninformedinamico { get; set; }

    [StringLength(500)]
    public string? nombreoriginaltabla1 { get; set; }

    [StringLength(500)]
    public string? nombreoriginaltabla2 { get; set; }

    [StringLength(500)]
    public string? camporelaciontabla1 { get; set; }

    [StringLength(500)]
    public string? camporelaciontabla2 { get; set; }

    [StringLength(500)]
    public string? nombrerelacion { get; set; }
}
