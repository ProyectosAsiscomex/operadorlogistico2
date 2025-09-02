using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class LetrasPermitida
{
    [Key]
    public int idLetrasPermitidas { get; set; }

    public int? CodigoLetra { get; set; }
}
