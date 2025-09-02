using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AndinaxDeclaracion")]
public partial class AndinaxDeclaracion
{
    [Key]
    public int idandinaxdeclaracion { get; set; }

    public int? iddeclaracion { get; set; }

    public int? idandina { get; set; }
}
