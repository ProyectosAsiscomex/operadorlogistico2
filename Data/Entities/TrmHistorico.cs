using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TrmHistorico")]
public partial class TrmHistorico
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "money")]
    public decimal? Trm { get; set; }
}
