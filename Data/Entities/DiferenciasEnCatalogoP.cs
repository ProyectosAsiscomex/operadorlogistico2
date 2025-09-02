using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("DiferenciasEnCatalogoP")]
public partial class DiferenciasEnCatalogoP
{
    public int? id { get; set; }
}
