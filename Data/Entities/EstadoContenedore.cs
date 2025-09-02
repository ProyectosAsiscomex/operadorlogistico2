using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class EstadoContenedore
{
    [Key]
    public int idestadocontenedor { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
