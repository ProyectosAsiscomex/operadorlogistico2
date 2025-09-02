using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("telefonosporempresa")]
public partial class telefonosporempresa
{
    [Key]
    public int idtelefono { get; set; }

    public int? idempresa { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? area { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? celular { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? extension { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? pais { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? fax { get; set; }
}
