using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DocumentosAjuntosCliente")]
public partial class DocumentosAjuntosCliente
{
    [Key]
    public int id { get; set; }

    public int? IdExportador { get; set; }

    [Unicode(false)]
    public string? Tipo { get; set; }

    [Unicode(false)]
    public string? NombreArchivo { get; set; }
}
