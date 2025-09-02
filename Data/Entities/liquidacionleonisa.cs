using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class liquidacionleonisa
{
    [Column("ID Compañia")]
    public int? ID_Compañia { get; set; }

    [Column("Identificación Grupo")]
    [StringLength(63)]
    [Unicode(false)]
    public string? Identificación_Grupo { get; set; }

    [Column("Cuenta Contable")]
    [StringLength(100)]
    public string? Cuenta_Contable { get; set; }

    [Column("Valor Debito")]
    [StringLength(100)]
    public string? Valor_Debito { get; set; }

    [Column("Valor Credito")]
    [StringLength(100)]
    public string? Valor_Credito { get; set; }

    [Column("One-Time")]
    [StringLength(100)]
    public string? One_Time { get; set; }

    [Column("Id.Moneda")]
    [StringLength(1)]
    [Unicode(false)]
    public string Id_Moneda { get; set; } = null!;

    [Column("Id. Moneda Trans")]
    [StringLength(3)]
    [Unicode(false)]
    public string Id__Moneda_Trans { get; set; } = null!;

    [Column("Vlr Deb. Otra Moneda")]
    [StringLength(1)]
    [Unicode(false)]
    public string Vlr_Deb__Otra_Moneda { get; set; } = null!;

    [Column("Vlr Cre.Otra Moneda")]
    [StringLength(1)]
    [Unicode(false)]
    public string Vlr_Cre_Otra_Moneda { get; set; } = null!;

    [Column("Linea Impuestos")]
    [StringLength(1)]
    [Unicode(false)]
    public string Linea_Impuestos { get; set; } = null!;

    [Column("Cod. Obligac. Fiscal")]
    [StringLength(1)]
    [Unicode(false)]
    public string Cod__Obligac__Fiscal { get; set; } = null!;

    [Column("Cod. Tipo Impuesto")]
    [StringLength(1)]
    [Unicode(false)]
    public string Cod__Tipo_Impuesto { get; set; } = null!;

    [Column("Tasa Impuestos")]
    [StringLength(1)]
    [Unicode(false)]
    public string Tasa_Impuestos { get; set; } = null!;

    [Column("Linea Gravable")]
    [StringLength(1)]
    [Unicode(false)]
    public string Linea_Gravable { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Formula { get; set; } = null!;

    [Column("Codigo de la Aplicación")]
    [StringLength(3)]
    [Unicode(false)]
    public string Codigo_de_la_Aplicación { get; set; } = null!;

    [Column("Nombre Opción Modulo Seguridad")]
    [StringLength(9)]
    [Unicode(false)]
    public string Nombre_Opción_Modulo_Seguridad { get; set; } = null!;

    [Column("Identificador de la transacción")]
    [StringLength(1)]
    [Unicode(false)]
    public string Identificador_de_la_transacción { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Acción { get; set; } = null!;

    [Column("Usuario Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Usuario_Proceso { get; set; } = null!;

    [Column("Fecha Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Fecha_Proceso { get; set; } = null!;

    [Column("Hora Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Hora_Proceso { get; set; } = null!;

    [Column("Programa Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Programa_Proceso { get; set; } = null!;

    [Column("Estado Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Estado_Proceso { get; set; } = null!;

    [Column("Mensaje de error")]
    [StringLength(1)]
    [Unicode(false)]
    public string Mensaje_de_error { get; set; } = null!;

    [Column("Id Transac. Encab.")]
    [StringLength(1)]
    [Unicode(false)]
    public string Id_Transac__Encab_ { get; set; } = null!;

    [Column("Cod. Origen. Trnsacc.")]
    [StringLength(1)]
    [Unicode(false)]
    public string Cod__Origen__Trnsacc_ { get; set; } = null!;

    [StringLength(30)]
    public string? Do { get; set; }

    [StringLength(100)]
    public string? fecha_rad { get; set; }

    [StringLength(100)]
    public string? CONCEPTO { get; set; }
}
