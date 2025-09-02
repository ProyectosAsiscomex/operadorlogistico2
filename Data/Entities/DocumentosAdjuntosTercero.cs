using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DocumentosAdjuntosTercero")]
public partial class DocumentosAdjuntosTercero
{
    [Key]
    public int id { get; set; }

    public int? IdTercero { get; set; }

    public string? Tipo { get; set; }

    public string? NombreArchivo { get; set; }
}
