using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CausalesError")]
public partial class CausalesError
{
    [Key]
    public int idcausaleserror { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }

    public string? descripcion { get; set; }
}
