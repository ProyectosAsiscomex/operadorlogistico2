using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Seguimiento")]
public partial class Seguimiento
{
    [Key]
    public int idSeguimiento { get; set; }

    public int? idDO { get; set; }

    public string? comentario { get; set; }

    public int? idcategoria { get; set; }
}
