using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class promediodemora
{
    [Key]
    public int idpromediodemoras { get; set; }

    public short? idano { get; set; }

    public short? idmes { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? trm { get; set; }

    [Column(TypeName = "money")]
    public decimal? demorasusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? demorascop { get; set; }

    [Column(TypeName = "money")]
    public decimal? nrocontenedores { get; set; }
}
