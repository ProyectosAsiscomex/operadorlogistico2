using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("trmexportador")]
public partial class trmexportador
{
    [Key]
    public int idtrmexportador { get; set; }

    public int? idexportador { get; set; }

    [Column(TypeName = "money")]
    public decimal? trm { get; set; }
}
