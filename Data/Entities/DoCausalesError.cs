using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DoCausalesError")]
public partial class DoCausalesError
{
    [Key]
    public int iddocausale { get; set; }

    public int? idDo { get; set; }

    public int? idcausaleerror { get; set; }
}
