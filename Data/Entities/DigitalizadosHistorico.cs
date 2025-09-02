using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("DigitalizadosHistorico")]
public partial class DigitalizadosHistorico
{
    public double? ID_ARCHIVOS_DO { get; set; }

    public double? ID_ARCHIVO { get; set; }

    [StringLength(255)]
    public string? NUMERO_DO { get; set; }

    public double? ano { get; set; }

    [StringLength(2)]
    public string? mes { get; set; }

    public int? ID_TIPO_ARCHIVO_ANEXO { get; set; }

    [Unicode(false)]
    public string? NOMBRE_ARCHIVO { get; set; }

    [Unicode(false)]
    public string? LONGITUD { get; set; }

    [Unicode(false)]
    public string? USUARIO_CREACION { get; set; }

    [Unicode(false)]
    public string? FECHA_CREACION { get; set; }
}
