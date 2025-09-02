using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class MasivoSubpartida
{
    [Key]
    public int idMasivo { get; set; }

    public int? idDo { get; set; }

    public int? idsubpartida { get; set; }

    [Unicode(false)]
    public string? desinicial { get; set; }

    [Unicode(false)]
    public string? desfinal { get; set; }
}
