using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("pvt")]
public partial class pvt
{
    public int? VendorID { get; set; }

    public int? Emp1 { get; set; }

    public int? Emp2 { get; set; }

    public int? Emp3 { get; set; }

    public int? Emp4 { get; set; }

    public int? Emp5 { get; set; }
}
