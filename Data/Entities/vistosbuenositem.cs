using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("vistosbuenositem")]
public partial class vistosbuenositem
{
    [Key]
    public int idvistobuenoitem { get; set; }

    public int? idvistobueno { get; set; }

    public int? idregistroitem { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? entidad { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? control { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }
}
