using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Tb_ConsecutivoCotizacione
{
    [Key]
    public int id { get; set; }

    public int? IdCotizacion { get; set; }

    public int? consecutivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }
}
