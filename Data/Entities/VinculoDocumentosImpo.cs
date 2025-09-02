using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("VinculoDocumentosImpo")]
public partial class VinculoDocumentosImpo
{
    [Key]
    public int IdVinculoDocumentos { get; set; }

    public int? IdDOIMPO { get; set; }

    public int? idMovimiento { get; set; }

    [StringLength(100)]
    public string? TipoDocumento { get; set; }

    public bool? pasado { get; set; }
}
