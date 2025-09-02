using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("proveedores_ib_final$")]
public partial class proveedores_ib_final_
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

    [StringLength(255)]
    public string? USUARIO_CREACION { get; set; }

    [StringLength(255)]
    public string? FECHA_CREACION { get; set; }

    [StringLength(255)]
    public string? USUARIO_MODIFICACION { get; set; }

    [StringLength(255)]
    public string? FECHA_MODIFICACION { get; set; }

    [StringLength(255)]
    public string? NUMERO_IDENTIFICACION_EXPORTADOR { get; set; }

    [StringLength(255)]
    public string? REPRESENTANTE { get; set; }

    public double? ID_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? BANCO { get; set; }

    [StringLength(255)]
    public string? CUENTA { get; set; }

    [StringLength(255)]
    public string? CIUDAD_CUENTA { get; set; }

    [StringLength(255)]
    public string? PAIS_CUENTA { get; set; }

    [StringLength(255)]
    public string? ES_DOW_TO_DOW { get; set; }

    [StringLength(255)]
    public string? ES_NOTIFICANTE { get; set; }

    [StringLength(255)]
    public string? ES_IMPORTADOR { get; set; }

    [StringLength(255)]
    public string? ES_CONSIGNATARIO { get; set; }

    [StringLength(255)]
    public string? ES_EXPORTADOR { get; set; }

    [StringLength(255)]
    public string? CODIGO_PROVEEDOR { get; set; }

    [StringLength(255)]
    public string? NOMBRE_CONTACTO { get; set; }

    [StringLength(255)]
    public string? CARGO_CONTACTO { get; set; }

    [StringLength(255)]
    public string? NOMBRE_CORTO { get; set; }

    [StringLength(255)]
    public string? ACTIVO { get; set; }

    public int? idimportador { get; set; }

    [Unicode(false)]
    public string? importador { get; set; }
}
