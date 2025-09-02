using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ExcepcionesImpo")]
public partial class ExcepcionesImpo
{
    [Key]
    public int idExcepcion { get; set; }

    public int? idPedido { get; set; }

    public int? idIndicadorIni { get; set; }

    public int? idIndicadorFin { get; set; }

    public int? Usuario { get; set; }

    [StringLength(700)]
    [Unicode(false)]
    public string? Motivo { get; set; }
}
