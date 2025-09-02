using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TipoDocumento")]
public partial class TipoDocumento
{
    [Key]
    public int iddocumento { get; set; }

    [StringLength(150)]
    public string? nombre { get; set; }

    [StringLength(100)]
    public string? tipo { get; set; }

    public bool? obligatorio { get; set; }

    public int? Orden { get; set; }

    public bool? listadechequeo { get; set; }

    public bool? documentosoporte { get; set; }

    public int? ordendocsoporte { get; set; }

    public int? CodigoDianSoporte { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DescBiblioteca { get; set; }

    public bool? TipoCOmbo { get; set; }

    [InverseProperty("DocumentoNavigation")]
    public virtual ICollection<Actividade> Actividades { get; set; } = new List<Actividade>();

    [InverseProperty("idDocumentoNavigation")]
    public virtual ICollection<DocumentosListaChequeo> DocumentosListaChequeos { get; set; } = new List<DocumentosListaChequeo>();

    [InverseProperty("idTipoDocumentoNavigation")]
    public virtual ICollection<SoporteDim> SoporteDims { get; set; } = new List<SoporteDim>();
}
