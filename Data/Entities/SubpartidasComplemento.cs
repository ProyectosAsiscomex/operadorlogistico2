using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SubpartidasComplemento")]
public partial class SubpartidasComplemento
{
    [Key]
    public int idcomplemento { get; set; }

    public int? idsubpartida { get; set; }

    public int? idvistobueno { get; set; }

    public int? iddatotecnico { get; set; }
}
