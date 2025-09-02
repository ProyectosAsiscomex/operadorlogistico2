using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("NumerosEnvioPlanilla")]
public partial class NumerosEnvioPlanilla
{
    [Key]
    public int NEnvio { get; set; }

    public bool Estado { get; set; }
}
