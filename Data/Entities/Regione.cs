using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Regione
{
    [Key]
    public int idregion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
