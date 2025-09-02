using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Situacion_Negocio
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column("Sucursal Operativa")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Sucursal_Operativa { get; set; }

    [Column("Numero Pedido")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Numero_Pedido { get; set; }

    [Column("Numero O.C")]
    [StringLength(1)]
    [Unicode(false)]
    public string Numero_O_C { get; set; } = null!;

    [Column("Tipo Regimen")]
    [StringLength(20)]
    [Unicode(false)]
    public string Tipo_Regimen { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Identificacion { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Tercero { get; set; }

    [Column("Identificacion Tercero")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Identificacion_Tercero { get; set; }

    [StringLength(100)]
    public string? Proveedor { get; set; }

    [Column("Tipo Mercancia")]
    [StringLength(1000)]
    public string? Tipo_Mercancia { get; set; }

    [StringLength(50)]
    public string? Emision { get; set; }

    [Column("Nro Factura")]
    public string? Nro_Factura { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Deposito { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ETA { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ETD { get; set; }

    [Column("Tipo Carga")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tipo_Carga { get; set; }

    [Unicode(false)]
    public string? Situación { get; set; }

    [Column("Estado DO")]
    [StringLength(200)]
    public string? Estado_DO { get; set; }

    public string? DocumentoTransporte { get; set; }

    [Unicode(false)]
    public string? UltimoSuceso { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraUltimoSuceso { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudadorigen { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ciudaddestino { get; set; }
}
