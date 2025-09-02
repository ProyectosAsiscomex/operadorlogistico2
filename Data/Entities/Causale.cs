using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Causale
{
    [Key]
    public int idcausal { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? descripcion { get; set; }
}
