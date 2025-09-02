using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPORALDESTINATARIOS")]
public partial class TEMPORALDESTINATARIO
{
    [StringLength(255)]
    public string? NUMERO_IDENTIFICACION { get; set; }

    [StringLength(255)]
    public string? numero_do { get; set; }

    [StringLength(255)]
    public string? tipo_documento_destinatario { get; set; }

    [StringLength(255)]
    public string? numero_identificacion_destin { get; set; }

    [StringLength(255)]
    public string? primer_apellido_destinatario { get; set; }

    [StringLength(255)]
    public string? segundo_apellido_destinatario { get; set; }

    [StringLength(255)]
    public string? primer_nombre_destinatario { get; set; }

    [StringLength(255)]
    public string? otros_nombres_destinatario { get; set; }

    [StringLength(255)]
    public string? razon_social_destinatario { get; set; }

    [StringLength(255)]
    public string? direccion_destinatario { get; set; }

    [StringLength(255)]
    public string? codigo_pais_destinatario { get; set; }

    [StringLength(255)]
    public string? ciudad_destinatario { get; set; }

    public int? IDEXPORTADOR { get; set; }

    public int? IDPAIS { get; set; }
}
