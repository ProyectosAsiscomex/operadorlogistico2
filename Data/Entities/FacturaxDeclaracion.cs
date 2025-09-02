using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FacturaxDeclaracion")]
public partial class FacturaxDeclaracion
{
    [Key]
    public int idfacturaxdecla { get; set; }

    public int? iddetallefacturaimportacion { get; set; }

    public int? iddeclaracion { get; set; }
}
