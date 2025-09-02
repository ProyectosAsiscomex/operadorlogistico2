using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Confcorreoscontenedore
{
    [Key]
    public int idcorreoscontenedores { get; set; }

    public int? idusuario { get; set; }

    public bool? generandodemoras { get; set; }

    public bool? proximosdemoras { get; set; }

    public bool? maximonacionalizar { get; set; }
}
