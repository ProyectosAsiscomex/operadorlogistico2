using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Deposito
{
    [Key]
    public int iddeposito { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? idtipo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? razonsocial { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigoSYGA { get; set; }
}
