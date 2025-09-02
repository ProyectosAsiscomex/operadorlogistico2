using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("UsuarioSigloXXIDetalle")]
public partial class UsuarioSigloXXIDetalle
{
    [Key]
    public int idUsuarioSigloXXIDetalle { get; set; }

    public int? idUsuarioSigloXXI { get; set; }

    public int? idAduana { get; set; }

    [ForeignKey("idAduana")]
    [InverseProperty("UsuarioSigloXXIDetalles")]
    public virtual aduana? idAduanaNavigation { get; set; }

    [ForeignKey("idUsuarioSigloXXI")]
    [InverseProperty("UsuarioSigloXXIDetalles")]
    public virtual UsuarioSigloXXI? idUsuarioSigloXXINavigation { get; set; }
}
