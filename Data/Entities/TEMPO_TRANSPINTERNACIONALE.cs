using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TEMPO_TRANSPINTERNACIONALES")]
public partial class TEMPO_TRANSPINTERNACIONALE
{
    [StringLength(255)]
    public string? NOMBRE_TRANSPORTADOR { get; set; }

    [StringLength(255)]
    public string? NIT { get; set; }

    [StringLength(255)]
    public string? TIPO_DOCUMENTO { get; set; }

    [StringLength(255)]
    public string? CODIGO_USUARIO { get; set; }

    [StringLength(255)]
    public string? TIPO_DOCUMENTO_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? IDENTIFICACION_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? NOMBRE_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? CODIGO_GARANTIA_FINALIZACION { get; set; }

    [StringLength(255)]
    public string? TIPO_GARANTIA_FINALIZACION { get; set; }

    [StringLength(255)]
    public string? NUMERO_GARANTIA_FINALIZACION { get; set; }

    [StringLength(255)]
    public string? VALOR_GARANTIA_FINALIZACION { get; set; }

    [StringLength(255)]
    public string? VIGENCIA_GARANTIA_FINALIZACION { get; set; }

    [StringLength(255)]
    public string? PRIMER_NOMBRE_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? OTROS_NOMBRES_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? PRIMER_APELLIDO_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? OTROS_APELLIDOS_REPRESENTANTE { get; set; }

    [StringLength(255)]
    public string? CODIGO_PAIS { get; set; }
}
