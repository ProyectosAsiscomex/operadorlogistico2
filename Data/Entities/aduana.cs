using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class aduana
{
    [Key]
    public int idaduana { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(100)]
    public string? descripcion { get; set; }

    [StringLength(100)]
    public string? diaslibres { get; set; }

    [StringLength(5)]
    public string? idciudad { get; set; }

    public bool? plastider { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [InverseProperty("idAduanaNavigation")]
    public virtual ICollection<UsuarioSigloXXIDetalle> UsuarioSigloXXIDetalles { get; set; } = new List<UsuarioSigloXXIDetalle>();
}
