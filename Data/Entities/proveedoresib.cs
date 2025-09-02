using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("proveedoresib")]
public partial class proveedoresib
{
    [Key]
    public int productoibreal { get; set; }

    public int? codigo { get; set; }

    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? fax { get; set; }

    public int? idpaisib { get; set; }

    public int? idpais { get; set; }

    [Unicode(false)]
    public string? CIUDADib { get; set; }

    public int? idimportador { get; set; }

    [Unicode(false)]
    public string? importador { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BD { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? correo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? sigla { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? codigo2 { get; set; }

    public int? idimportadorasiscomex { get; set; }

    [Unicode(false)]
    public string? nitimportador { get; set; }
}
