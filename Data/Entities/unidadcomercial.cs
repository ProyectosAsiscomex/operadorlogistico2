using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("unidadcomercial")]
public partial class unidadcomercial
{
    [Key]
    public int idunidadcomercial { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(50)]
    public string? nombre { get; set; }

    [StringLength(10)]
    public string? abreviatura { get; set; }

    [StringLength(10)]
    public string? CodigoImportaciones { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? codigocliente { get; set; }
}
