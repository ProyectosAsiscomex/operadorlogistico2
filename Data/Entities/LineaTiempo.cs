using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LineaTiempo")]
public partial class LineaTiempo
{
    [Key]
    public int idLineaTiempo { get; set; }

    [StringLength(200)]
    public string? banda { get; set; }

    public int? ancho { get; set; }

    public int? alto { get; set; }

    public int? idusuario { get; set; }

    public bool? Visible { get; set; }
}
