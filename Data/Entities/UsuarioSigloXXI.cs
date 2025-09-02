using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("UsuarioSigloXXI")]
public partial class UsuarioSigloXXI
{
    [Key]
    public int idUsuarioSigloXXI { get; set; }

    public int? idUsuario { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? UsuarioSiglo { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? ClaveSiglo { get; set; }

    public bool? Habilitado { get; set; }

    [InverseProperty("idUsuarioSigloXXINavigation")]
    public virtual ICollection<UsuarioSigloXXIDetalle> UsuarioSigloXXIDetalles { get; set; } = new List<UsuarioSigloXXIDetalle>();

    [ForeignKey("idUsuario")]
    [InverseProperty("UsuarioSigloXXIs")]
    public virtual usuario? idUsuarioNavigation { get; set; }
}
