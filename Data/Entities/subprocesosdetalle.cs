using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("subprocesosdetalle")]
public partial class subprocesosdetalle
{
    [Key]
    public int idsubprocesodetalle { get; set; }

    public int? idsubproceso { get; set; }

    public int? orden { get; set; }

    public int? IdGasto { get; set; }
}
