using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPO_IMPORTADORES")]
public partial class TEMPO_IMPORTADORE
{
    [StringLength(255)]
    public string? numero_identificacion { get; set; }

    [StringLength(255)]
    public string? nombre_importador { get; set; }

    [StringLength(255)]
    public string? ciudad_domicilio { get; set; }

    [StringLength(255)]
    public string? direccion { get; set; }

    [StringLength(255)]
    public string? telefono { get; set; }

    [StringLength(255)]
    public string? fax { get; set; }

    [StringLength(255)]
    public string? email { get; set; }

    [StringLength(255)]
    public string? representante_legal { get; set; }

    [StringLength(255)]
    public string? tipo_importador { get; set; }

    [StringLength(255)]
    public string? codigo_act_economica { get; set; }

    [StringLength(255)]
    public string? clase_importador { get; set; }

    [StringLength(255)]
    public string? tipo_actividad { get; set; }

    [StringLength(255)]
    public string? nombre_contacto { get; set; }

    [StringLength(255)]
    public string? nombre_corto { get; set; }

    public double? porcentaje_seguro { get; set; }

    [StringLength(255)]
    public string? codigo_uap { get; set; }

    [StringLength(255)]
    public string? codigo_sucursal_comercial { get; set; }

    [StringLength(255)]
    public string? numero_mandato { get; set; }

    [StringLength(255)]
    public string? fecha_mandato { get; set; }

    [StringLength(255)]
    public string? fecha_vencimiento_mandato { get; set; }

    [StringLength(255)]
    public string? nit_representante { get; set; }
}
