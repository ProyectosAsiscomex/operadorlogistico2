using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("NumerosEnvio")]
public partial class NumerosEnvio
{
    [Key]
    public int NEnvio { get; set; }

    public bool Estado { get; set; }
}
