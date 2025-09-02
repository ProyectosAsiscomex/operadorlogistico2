using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CheckDocumentositem")]
public partial class CheckDocumentositem
{
    [Key]
    public int idCheckDocumentositem { get; set; }

    public int? idCheckDocumentos { get; set; }

    [StringLength(200)]
    public string? nombredocumento { get; set; }

    [StringLength(200)]
    public string? uso { get; set; }

    public string? observaciones { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafinal { get; set; }
}
