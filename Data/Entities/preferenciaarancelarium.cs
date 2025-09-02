using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class preferenciaarancelarium
{
    [Key]
    public int idpreferencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? descripcion { get; set; }
}
