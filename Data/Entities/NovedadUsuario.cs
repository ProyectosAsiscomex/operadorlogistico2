using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("NovedadUsuario")]
public partial class NovedadUsuario
{
    [Key]
    public int idNovedadUsuario { get; set; }

    public int? idNovedad { get; set; }

    public int? idUsuario { get; set; }
}
