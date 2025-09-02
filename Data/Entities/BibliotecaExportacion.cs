using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("BibliotecaExportacion")]
public partial class BibliotecaExportacion
{
    public int idBiblioteca { get; set; }

    public int? idFactExpo { get; set; }

    public int? idEntrega { get; set; }

    public string? cComentario { get; set; }

    [StringLength(100)]
    public string? cArchivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? cFechaUpload { get; set; }

    [StringLength(100)]
    public string? despacho { get; set; }

    [StringLength(100)]
    public string? url { get; set; }
}
