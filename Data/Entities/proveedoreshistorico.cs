using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("proveedoreshistorico")]
public partial class proveedoreshistorico
{
    public int? idproveedor { get; set; }

    [StringLength(200)]
    public string? codigo { get; set; }

    public string? nombre { get; set; }

    public string? direccion { get; set; }

    [StringLength(300)]
    public string? telefono { get; set; }

    [StringLength(300)]
    public string? fax { get; set; }

    public int? idmoneda { get; set; }

    public int? idpais { get; set; }

    [StringLength(300)]
    public string? CIUDAD { get; set; }

    [StringLength(300)]
    public string? correo { get; set; }

    [StringLength(300)]
    public string? contacto { get; set; }

    public int? idincoterm { get; set; }

    public int? idlugarembarque { get; set; }

    public int? terminosdenegociacion { get; set; }

    public int? idimportador { get; set; }
}
