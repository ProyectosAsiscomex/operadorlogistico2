using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Informe_Uap_Aduanimex
{
    public int? idexportador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NIT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    public int? ANIO { get; set; }

    [StringLength(30)]
    public string? MES { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha { get; set; }

    public string? Pedido { get; set; }

    [Column("Nro D.O.")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_D_O_ { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Item { get; set; }

    [Column("Nro Declaracion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Declaracion { get; set; }

    [Column("Fecha Declaracion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Fecha_Declaracion { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Aduana { get; set; }

    [Column("Tipo Declaración")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Tipo_Declaración { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Modalidad { get; set; }

    [Column("Liquidado Arancel", TypeName = "money")]
    public decimal? Liquidado_Arancel { get; set; }

    [Column("Liquidado IVA", TypeName = "money")]
    public decimal? Liquidado_IVA { get; set; }

    [Column(TypeName = "money")]
    public decimal? Rescate { get; set; }

    [Column(TypeName = "money")]
    public decimal? Antidumping { get; set; }

    [Column("Total Liquidado", TypeName = "money")]
    public decimal? Total_Liquidado { get; set; }

    [Column("Nro Aceptación")]
    [StringLength(100)]
    public string? Nro_Aceptación { get; set; }

    [Column("Fecha Aceptación", TypeName = "smalldatetime")]
    public DateTime? Fecha_Aceptación { get; set; }

    [Column("Nro Levante")]
    [StringLength(100)]
    public string? Nro_Levante { get; set; }

    [Column("Fecha Levante", TypeName = "smalldatetime")]
    public DateTime? Fecha_Levante { get; set; }
}
