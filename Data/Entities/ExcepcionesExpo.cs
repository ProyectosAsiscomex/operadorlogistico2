using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ExcepcionesExpo")]
public partial class ExcepcionesExpo
{
    [Key]
    public int idExcepcion { get; set; }

    public int? idMovimiento { get; set; }

    public int? idusuario { get; set; }

    [StringLength(700)]
    [Unicode(false)]
    public string? Motivo { get; set; }

    public int? iddetalleIndicador { get; set; }
}
