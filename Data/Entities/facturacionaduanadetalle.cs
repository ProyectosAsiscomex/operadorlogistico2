using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("facturacionaduanadetalle")]
public partial class facturacionaduanadetalle
{
    [Key]
    public int idfacturacionaduanadetalle { get; set; }

    public int? idfacturacionaduana { get; set; }

    public int? idliquidacionesitem { get; set; }
}
