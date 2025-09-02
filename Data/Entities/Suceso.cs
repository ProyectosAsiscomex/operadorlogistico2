using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Suceso
{
    [Key]
    public int idSuceso { get; set; }

    [StringLength(200)]
    public string? tipo { get; set; }

    public int? idPkTipo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    public string? comentario { get; set; }

    [StringLength(300)]
    public string? vinculodirecto { get; set; }

    public int? idusuario { get; set; }

    [StringLength(200)]
    public string? usuario { get; set; }

    public int? idexportador { get; set; }

    public bool? publico { get; set; }
}
