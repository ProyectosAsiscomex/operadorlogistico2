using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DocumentosDIAN")]
public partial class DocumentosDIAN
{
    [Key]
    public int idDocumentosDian { get; set; }

    public int? idExportador { get; set; }

    [StringLength(50)]
    public string? NombreDocumento { get; set; }

    public bool? Aplicar { get; set; }

    public bool? NoAplica { get; set; }
}
