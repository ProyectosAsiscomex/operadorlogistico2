using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class PalabrasEspeciale
{
    [Key]
    public int idPalabraEspecial { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? palabra { get; set; }
}
