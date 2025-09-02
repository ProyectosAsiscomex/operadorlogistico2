using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("UsuarioMuisca")]
public partial class UsuarioMuisca
{
    [Key]
    public int idUsuarioMuisca { get; set; }

    public int? idUsuario { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nit { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? Clave { get; set; }

    public int? TipoIngreso { get; set; }
}
