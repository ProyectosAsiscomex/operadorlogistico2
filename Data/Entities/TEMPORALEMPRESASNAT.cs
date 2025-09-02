using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALEMPRESASNAT")]
public partial class TEMPORALEMPRESASNAT
{
    [StringLength(255)]
    public string? NUMERO_IDENTIFICACION { get; set; }

    [StringLength(255)]
    public string? NOMBRE_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CIUDAD_DOMICILIO { get; set; }

    [StringLength(255)]
    public string? DIRECCION { get; set; }

    [StringLength(255)]
    public string? TELEFONO { get; set; }

    [StringLength(255)]
    public string? FAX { get; set; }

    [StringLength(255)]
    public string? EMAIL { get; set; }

    [StringLength(255)]
    public string? REPRESENTANTE_LEGAL { get; set; }

    [StringLength(255)]
    public string? CODIGO_CLASE_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_UAP { get; set; }

    [StringLength(255)]
    public string? CODIGO_SUCURSAL_COMERCIAL { get; set; }

    [StringLength(255)]
    public string? NIT_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? CARGO_CONTACTO { get; set; }

    public int? idciudaadDO { get; set; }
}
