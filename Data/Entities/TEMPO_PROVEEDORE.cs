using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPO_PROVEEDORES")]
public partial class TEMPO_PROVEEDORE
{
    public double? ID_EXPORTADOR { get; set; }

    [StringLength(255)]
    public string? NOMBRE_EXPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_PAIS { get; set; }

    [StringLength(255)]
    public string? CIUDAD { get; set; }

    [StringLength(255)]
    public string? CODIGO_CONDICION_PROV { get; set; }

    [StringLength(255)]
    public string? ESPECIFIQUE { get; set; }

    [StringLength(255)]
    public string? DIRECCION { get; set; }

    [StringLength(255)]
    public string? TELEFONO { get; set; }

    [StringLength(255)]
    public string? FAX { get; set; }

    [StringLength(255)]
    public string? EMAIL { get; set; }

    public double? ID_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_PROVEEDOR { get; set; }

    [StringLength(255)]
    public string? NOMBRE_CONTACTO { get; set; }
}
