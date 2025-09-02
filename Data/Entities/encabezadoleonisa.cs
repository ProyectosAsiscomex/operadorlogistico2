using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class encabezadoleonisa
{
    [Column("ID Compañia")]
    public int? ID_Compañia { get; set; }

    [Column("Identificación Grupo")]
    [StringLength(93)]
    [Unicode(false)]
    public string? Identificación_Grupo { get; set; }

    [Column("Fecha Aplicación", TypeName = "datetime")]
    public DateTime Fecha_Aplicación { get; set; }

    [Column("Código De Diario")]
    [StringLength(4)]
    [Unicode(false)]
    public string Código_De_Diario { get; set; } = null!;

    [StringLength(111)]
    [Unicode(false)]
    public string? Descripción { get; set; }

    [Column("Tipo Documento")]
    [StringLength(4)]
    [Unicode(false)]
    public string Tipo_Documento { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Prefijo { get; set; } = null!;

    [Column("Número Legal")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Número_Legal { get; set; }

    [Column("Gestion de Impuesto")]
    [StringLength(1)]
    [Unicode(false)]
    public string Gestion_de_Impuesto { get; set; } = null!;

    [Column("Codigo de la aplicación")]
    [StringLength(3)]
    [Unicode(false)]
    public string Codigo_de_la_aplicación { get; set; } = null!;

    [Column("Nombre Opción")]
    [StringLength(9)]
    [Unicode(false)]
    public string Nombre_Opción { get; set; } = null!;

    [Column("Identificador de la Transacción")]
    [StringLength(1)]
    [Unicode(false)]
    public string Identificador_de_la_Transacción { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Acción { get; set; } = null!;

    [Column("Usuario Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Usuario_Proceso { get; set; } = null!;

    [Column("Fecha Proceso Epicor")]
    [StringLength(1)]
    [Unicode(false)]
    public string Fecha_Proceso_Epicor { get; set; } = null!;

    [Column("Hora Proceso Epicor")]
    [StringLength(1)]
    [Unicode(false)]
    public string Hora_Proceso_Epicor { get; set; } = null!;

    [Column("Programa Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Programa_Proceso { get; set; } = null!;

    [Column("Estado Proceso")]
    [StringLength(1)]
    [Unicode(false)]
    public string Estado_Proceso { get; set; } = null!;

    [Column("Mensaje Error")]
    [StringLength(1)]
    [Unicode(false)]
    public string Mensaje_Error { get; set; } = null!;

    [Column("Fecha Carga Datos")]
    [StringLength(1)]
    [Unicode(false)]
    public string Fecha_Carga_Datos { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Hora { get; set; } = null!;

    [StringLength(100)]
    public string? Do { get; set; }

    [Column("Nro Pedido")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Pedido { get; set; }

    [StringLength(100)]
    public string? fecha_rad { get; set; }
}
