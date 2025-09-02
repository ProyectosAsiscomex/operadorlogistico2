using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SignatarioDTA")]
public partial class SignatarioDTum
{
    [Key]
    public int idsignatario { get; set; }

    public int? iddeclarante { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tipodocumento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? dv { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? segundoapellido { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? otrosnombres { get; set; }

    public bool? habilitado { get; set; }
}
