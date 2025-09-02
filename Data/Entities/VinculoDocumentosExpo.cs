using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("VinculoDocumentosExpo")]
public partial class VinculoDocumentosExpo
{
    [Key]
    public int IdVinculoDocumentosExpo { get; set; }

    public int? IdDOEXPO { get; set; }

    public int? idMovimiento { get; set; }

    [StringLength(100)]
    public string? TipoDocumento { get; set; }
}
