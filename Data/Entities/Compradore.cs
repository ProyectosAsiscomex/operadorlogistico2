using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Compradore
{
    [Key]
    public int idcomprador { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? nombre { get; set; }

    public int? idpais { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? fax { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? correo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IDVINCULO { get; set; }
}
