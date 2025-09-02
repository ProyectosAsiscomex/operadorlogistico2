using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("MinimasRelacion")]
public partial class MinimasRelacion
{
    [Key]
    public int idrelacion { get; set; }

    public int? iddescripcion { get; set; }

    public int? idarancel { get; set; }

    public int? IDCLASIFICACION { get; set; }

    public int? ORDEN { get; set; }
}
