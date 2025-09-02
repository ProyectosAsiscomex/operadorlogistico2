using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class descripcionpartida
{
    [Key]
    public int idpartida { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? partida { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }
}
