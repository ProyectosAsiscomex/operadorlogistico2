using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class cuadros_insumos_producto
{
    public int? ID_CUADRO_INSUMO_PRODUCTO { get; set; }

    public int ID_IMPORTADOR { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string CODIGO_ADMINISTRACION { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CODIGO_POSICION { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string CODIGO_UNIDAD_FISICA { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TIPO_CIP { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? LETRAS_PROGRAMA { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CONSECUTIVO_PROGRAMA { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string NUMERO_CIP { get; set; } = null!;

    [Column(TypeName = "decimal(15, 5)")]
    public decimal FOB_USD_UNIDAD { get; set; }

    [Column(TypeName = "decimal(7, 3)")]
    public decimal PORCENTAJE_VAN_UNIDAD { get; set; }

    [Column(TypeName = "decimal(15, 5)")]
    public decimal PESO_NETO_UNIDAD { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string DESCRIPCION_PRODUCTO { get; set; } = null!;

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? VALOR_EXPORTADO { get; set; }
}
