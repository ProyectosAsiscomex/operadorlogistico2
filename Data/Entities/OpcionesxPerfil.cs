using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("OpcionesxPerfil")]
public partial class OpcionesxPerfil
{
    [Key]
    public int id_formulario { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [Unicode(false)]
    public string? ruta { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? tipo { get; set; }
}
