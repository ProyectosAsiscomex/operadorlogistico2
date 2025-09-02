using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Naviera
{
    [Key]
    public int idnaviera { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? agencia { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? controlador { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? codigo { get; set; }

    public short? diaslibres { get; set; }

    public bool? habilitado { get; set; }

    public bool? aerolinea { get; set; }
}
