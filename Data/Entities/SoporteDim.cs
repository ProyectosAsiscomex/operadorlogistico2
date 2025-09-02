using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SoporteDim")]
public partial class SoporteDim
{
    [Key]
    public int idSoporteDim { get; set; }

    public int? idDeclaracion { get; set; }

    public int? idTipoDocumento { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    public bool? Presentado { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Radicado { get; set; }

    [ForeignKey("idDeclaracion")]
    [InverseProperty("SoporteDims")]
    public virtual declaracionImportacion? idDeclaracionNavigation { get; set; }

    [ForeignKey("idTipoDocumento")]
    [InverseProperty("SoporteDims")]
    public virtual TipoDocumento? idTipoDocumentoNavigation { get; set; }
}
