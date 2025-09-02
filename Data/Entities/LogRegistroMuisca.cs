using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("LogRegistroMuisca")]
public partial class LogRegistroMuisca
{
    [Key]
    public int idLog { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? URLFormulario { get; set; }

    public int? IdUsuarioResponsable { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TipoOperacion { get; set; }
}
