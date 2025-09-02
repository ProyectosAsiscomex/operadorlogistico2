using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("agentesenelexterior")]
public partial class agentesenelexterior
{
    [Key]
    public int idagenteexterior { get; set; }

    public string? nombre { get; set; }

    public string? direccion { get; set; }

    [StringLength(300)]
    public string? telefono { get; set; }

    [StringLength(300)]
    public string? fax { get; set; }

    public int? idpais { get; set; }

    [StringLength(300)]
    public string? CIUDAD { get; set; }

    [StringLength(300)]
    public string? correo { get; set; }

    [StringLength(300)]
    public string? contacto { get; set; }

    public bool? habilitado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Cargo { get; set; }
}
