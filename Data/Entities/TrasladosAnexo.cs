using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TrasladosAnexo")]
public partial class TrasladosAnexo
{
    [Key]
    public int idtrasladoanexo { get; set; }

    public int? idtraslado { get; set; }

    [StringLength(300)]
    public string? archivo { get; set; }

    [StringLength(300)]
    public string? descripcion { get; set; }
}
