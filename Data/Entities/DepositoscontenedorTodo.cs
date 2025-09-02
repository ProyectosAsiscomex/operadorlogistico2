using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class DepositoscontenedorTodo
{
    [StringLength(250)]
    [Unicode(false)]
    public string? Compañia { get; set; }

    [Column("Agente o Naviera")]
    [StringLength(100)]
    public string? Agente_o_Naviera { get; set; }

    [Column("Fecha Factura", TypeName = "smalldatetime")]
    public DateTime? Fecha_Factura { get; set; }

    [Column("Nro Factura")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nro_Factura { get; set; }

    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? Valor { get; set; }

    public string Pedido { get; set; } = null!;

    [Column("B/L")]
    [StringLength(50)]
    [Unicode(false)]
    public string? B_L { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Sede { get; set; }

    [Column("No.Contenedor")]
    public string No_Contenedor { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal Recibido { get; set; }

    [Unicode(false)]
    public string Observaciones { get; set; } = null!;

    [Column("Nro Contable")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nro_Contable { get; set; } = null!;
}
