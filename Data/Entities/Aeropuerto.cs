using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Aeropuerto
{
    [Key]
    public int idaeropuerto { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idpais { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
