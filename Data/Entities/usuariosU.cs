using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("usuariosU")]
public partial class usuariosU
{
    [Key]
    public int idusuario { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? correo { get; set; }
}
