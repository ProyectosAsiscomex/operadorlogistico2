using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TamanioContenedorFull")]
public partial class TamanioContenedorFull
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Nombre { get; set; }
}
