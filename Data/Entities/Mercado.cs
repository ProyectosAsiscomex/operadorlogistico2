using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Mercado
{
    [Key]
    public int idmercado { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? descripcion { get; set; }

    public int? idimportador { get; set; }

    public bool? predeterminado { get; set; }

    public int? idpais { get; set; }
}
