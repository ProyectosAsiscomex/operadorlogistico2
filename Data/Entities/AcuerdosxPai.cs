using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AcuerdosxPai
{
    [Key]
    public int IdacuerdoPais { get; set; }

    public int? IdAcuerdo { get; set; }

    public int? IdPais { get; set; }
}
