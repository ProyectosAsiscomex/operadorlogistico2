using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Activacionalerta
{
    [Key]
    public int idactivacionalertas { get; set; }

    public int? idestado { get; set; }

    public bool? cambiofechainicial { get; set; }

    public bool? cambiofechafinal { get; set; }

    public bool? comentario { get; set; }

    public bool? congelardecongelar { get; set; }
}
