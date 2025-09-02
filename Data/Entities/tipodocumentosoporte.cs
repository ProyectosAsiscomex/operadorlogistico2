using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tipodocumentosoporte")]
public partial class tipodocumentosoporte
{
    [Key]
    public int idtipodocumentosoporte { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? descripcion { get; set; }
}
