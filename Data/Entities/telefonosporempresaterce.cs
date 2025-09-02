using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("telefonosporempresaterce")]
public partial class telefonosporempresaterce
{
    [Key]
    public int idtelefono { get; set; }

    public int? idempresa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? area { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? celular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? extension { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pais { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? fax { get; set; }
}
