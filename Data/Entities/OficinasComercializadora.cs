using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class OficinasComercializadora
{
    [Key]
    public int idoficinacomercializadora { get; set; }

    [StringLength(100)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
