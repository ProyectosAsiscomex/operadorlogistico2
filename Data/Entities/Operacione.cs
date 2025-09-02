using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Operacione
{
    public int iddo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Do { get; set; }

    [StringLength(200)]
    public string? Estado { get; set; }

    [StringLength(100)]
    public string? Nro_Factura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_SAE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha_SAE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Dex_Definitivo { get; set; }

    [StringLength(500)]
    public string? Ultimo_Tramite { get; set; }

    [StringLength(500)]
    public string? Tramite_Actual { get; set; }

    public string? Ultimo_Comentario { get; set; }

    [StringLength(500)]
    public string? Proximo_Tramite { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Dex_Definitivo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha_Creacion { get; set; }

    public int? Sede_Comercializadora { get; set; }

    [StringLength(803)]
    public string? Asesor_Comercial { get; set; }

    public int? Sede_Operativa { get; set; }

    [StringLength(803)]
    public string? Asesor_Operativo { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Exportador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Destinatario { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Transportador { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Modo_Transporte { get; set; }

    [StringLength(100)]
    public string? Moneda { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_Referencia { get; set; }

    public string? Observaciones { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tasa_Cambio { get; set; }

    [StringLength(100)]
    public string? Tipo_Operacion { get; set; }

    [StringLength(200)]
    public string? Embarcador { get; set; }

    [StringLength(100)]
    public string? Transportador_Nacional { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Carga { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? Cantidad_Carga { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? Cantidad_Contenedores { get; set; }

    public bool? Mcia_Peligrosa { get; set; }
}
