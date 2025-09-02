using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class nrosFraccionada
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string nroFraccionada { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? estado { get; set; }
}
