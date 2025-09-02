using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class VistosBueno
{
    [Key]
    public int idvistobueno { get; set; }

    [StringLength(3)]
    public string? codigo { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? codigoBPM { get; set; }
}
