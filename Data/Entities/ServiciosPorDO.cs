using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ServiciosPorDO")]
public partial class ServiciosPorDO
{
    [Key]
    public int idServiciosPorDO { get; set; }

    public int? idDO { get; set; }

    public int? idTercero { get; set; }

    [StringLength(1000)]
    public string? NombreServicio { get; set; }
}
