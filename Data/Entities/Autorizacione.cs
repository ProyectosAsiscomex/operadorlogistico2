using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Autorizacione
{
    [Key]
    public int idautorizacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? monto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaautoriza { get; set; }

    public int? idusuarioautoriza { get; set; }

    public int? iddo { get; set; }

    [StringLength(50)]
    public string? nrodo { get; set; }
}
