using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class TablaNuevo
{
    public int idtemporalnuevo { get; set; }

    public int? idproducto { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombrecolumna { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? datos { get; set; }
}
