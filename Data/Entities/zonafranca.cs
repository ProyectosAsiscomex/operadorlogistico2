using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("zonafranca")]
public partial class zonafranca
{
    [Key]
    public int idzonafranca { get; set; }

    public int? idaduana { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CodigoSYGA { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? nit { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Departamento { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? Ciudad { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? TipoUsuario { get; set; }
}
