using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class OperacionesEXPO
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaCreacion { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(100)]
    public string? TIPO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Sucursal_Operativa { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Valor_FOB { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Carga { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Deposito { get; set; }

    [StringLength(50)]
    public string? Pais_Destino { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Destinatario { get; set; }

    public string? Mercancia { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_Transporte { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Transportador { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Sistemas_Especiales { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha_Cut_OFF { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha_Real_Embarque { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Originales { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Ingreso_Deposito { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Autorizacion_Embarque { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Selectividad_Aduanera { get; set; }
}
