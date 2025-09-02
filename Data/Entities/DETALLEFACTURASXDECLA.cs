using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("DETALLEFACTURASXDECLAS")]
public partial class DETALLEFACTURASXDECLA
{
    public int? iddetallefacturaimportacion { get; set; }

    public int? iddeclaimpo { get; set; }

    public int? IDDO { get; set; }

    public int? idfacturaimpo { get; set; }
}
