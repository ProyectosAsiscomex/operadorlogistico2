using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TipoImportacion")]
public partial class TipoImportacion
{
    [Key]
    public int idtipoimportacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? descripcion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codigo { get; set; }
}
