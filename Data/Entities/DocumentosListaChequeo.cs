using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DocumentosListaChequeo")]
public partial class DocumentosListaChequeo
{
    [Key]
    public int idDocumentosListaChequeo { get; set; }

    public int? idDocumento { get; set; }

    public int? idListaChequeoEncabezado { get; set; }

    public bool? Uso { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Observaciones { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharecepcion { get; set; }

    public bool? original { get; set; }

    public bool? sinrecibir { get; set; }

    public bool? requerido { get; set; }

    [ForeignKey("idDocumento")]
    [InverseProperty("DocumentosListaChequeos")]
    public virtual TipoDocumento? idDocumentoNavigation { get; set; }

    [ForeignKey("idListaChequeoEncabezado")]
    [InverseProperty("DocumentosListaChequeos")]
    public virtual ListaChequeoEncabezado? idListaChequeoEncabezadoNavigation { get; set; }
}
