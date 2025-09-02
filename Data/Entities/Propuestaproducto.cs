using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Propuestaproducto
{
    [Key]
    public int idpropuestaproducto { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? descripcion { get; set; }
}
