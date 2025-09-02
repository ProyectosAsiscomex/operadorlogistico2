using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EstadoElimiadoPorDO")]
public partial class EstadoElimiadoPorDO
{
    [Key]
    public int idEstadoEliminado { get; set; }

    public int? idDO { get; set; }

    public int? idEstado { get; set; }
}
