using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class LiquidacionPrebelEncabezado
{
    [Column("Nro DO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nro_DO { get; set; }

    [Column("Nro Auxiliar")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nro_Auxiliar { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sticker { get; set; }

    [Column("Fecha Sticker")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Fecha_Sticker { get; set; }

    [Column("Numero Aceptación")]
    [StringLength(100)]
    public string? Numero_Aceptación { get; set; }

    [Column("Fecha aceptación", TypeName = "smalldatetime")]
    public DateTime? Fecha_aceptación { get; set; }

    [Column("Numero de Levante")]
    [StringLength(100)]
    public string? Numero_de_Levante { get; set; }

    [Column("Fecha levante", TypeName = "smalldatetime")]
    public DateTime? Fecha_levante { get; set; }

    [Column("Código Aduana")]
    [StringLength(4000)]
    public string? Código_Aduana { get; set; }

    [Column("Código lugar de ingreso")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Código_lugar_de_ingreso { get; set; }

    [Column("Código del deposito")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Código_del_deposito { get; set; }

    [Column("Numero del B/L HIJO")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Numero_del_B_L_HIJO { get; set; }

    [Column("Fecha del B/L", TypeName = "smalldatetime")]
    public DateTime? Fecha_del_B_L { get; set; }

    [Column("Numero de Factura")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Numero_de_Factura { get; set; }

    [StringLength(200)]
    public string? Proveedor { get; set; }

    [Column("Numero Proyecto ")]
    [StringLength(2)]
    [Unicode(false)]
    public string Numero_Proyecto_ { get; set; } = null!;

    [Column("Código agente de aduana")]
    [StringLength(6)]
    [Unicode(false)]
    public string Código_agente_de_aduana { get; set; } = null!;

    [Column("Tasa de cambio Dólar - Peso", TypeName = "decimal(30, 8)")]
    public decimal? Tasa_de_cambio_Dólar___Peso { get; set; }

    [Column("Tasa de cambio Moneda - Dólar")]
    [StringLength(3)]
    [Unicode(false)]
    public string Tasa_de_cambio_Moneda___Dólar { get; set; } = null!;

    [Column("Posición arancelaria")]
    [StringLength(20)]
    public string? Posición_arancelaria { get; set; }

    [Column("Modalidad aduanera")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Modalidad_aduanera { get; set; }

    [Column("Tipo de importación")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Tipo_de_importación { get; set; }

    [Column("Peso Bruto", TypeName = "decimal(30, 2)")]
    public decimal? Peso_Bruto { get; set; }

    [Column("Peso Neto", TypeName = "decimal(30, 2)")]
    public decimal? Peso_Neto { get; set; }

    [Column("Código unidad de aduana")]
    [StringLength(1)]
    [Unicode(false)]
    public string Código_unidad_de_aduana { get; set; } = null!;

    [Column("Cantidad de aduana", TypeName = "decimal(30, 2)")]
    public decimal? Cantidad_de_aduana { get; set; }

    [Column("Valor FOB", TypeName = "money")]
    public decimal? Valor_FOB { get; set; }

    [Column("Valor Flete", TypeName = "money")]
    public decimal? Valor_Flete { get; set; }

    [Column("Valor Seguros", TypeName = "money")]
    public decimal? Valor_Seguros { get; set; }

    [Column("Valor Otros Gastos", TypeName = "money")]
    public decimal? Valor_Otros_Gastos { get; set; }

    [Column("Valor Ajuste", TypeName = "decimal(30, 2)")]
    public decimal? Valor_Ajuste { get; set; }

    [Column("Signo del Ajuste")]
    [StringLength(1)]
    [Unicode(false)]
    public string Signo_del_Ajuste { get; set; } = null!;

    [Column("Registro/Licencia Mincomex")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Registro_Licencia_Mincomex { get; set; }

    [Column("Año del registro")]
    public int? Año_del_registro { get; set; }

    [Column("% arancel", TypeName = "decimal(30, 2)")]
    public decimal? __arancel { get; set; }

    [Column("Valor Arancel", TypeName = "money")]
    public decimal? Valor_Arancel { get; set; }

    [Column("Indicativo arancel exento")]
    [StringLength(1)]
    [Unicode(false)]
    public string Indicativo_arancel_exento { get; set; } = null!;

    [Column("%IVA", TypeName = "decimal(30, 2)")]
    public decimal? _IVA { get; set; }

    [Column("Valor IVA", TypeName = "money")]
    public decimal? Valor_IVA { get; set; }

    [Column("Indicativo iva exento")]
    [StringLength(1)]
    [Unicode(false)]
    public string Indicativo_iva_exento { get; set; } = null!;

    [Column("Valor Sanciones", TypeName = "money")]
    public decimal? Valor_Sanciones { get; set; }

    [Column("Valor Otros", TypeName = "money")]
    public decimal? Valor_Otros { get; set; }

    [Column("Pagos Anteriores", TypeName = "money")]
    public decimal? Pagos_Anteriores { get; set; }

    [Column("Valor pagado en efectivo", TypeName = "money")]
    public decimal? Valor_pagado_en_efectivo { get; set; }

    [Column("Valor pagado Cheque")]
    public int Valor_pagado_Cheque { get; set; }

    [Column("Numero del cheque")]
    [StringLength(1)]
    [Unicode(false)]
    public string Numero_del_cheque { get; set; } = null!;

    [Column("Indicativo registro convertido")]
    [StringLength(1)]
    [Unicode(false)]
    public string Indicativo_registro_convertido { get; set; } = null!;

    [Column("Drop Off")]
    [StringLength(1)]
    [Unicode(false)]
    public string Drop_Off { get; set; } = null!;

    [Column("Lugar entrega del contenedor")]
    [StringLength(1)]
    [Unicode(false)]
    public string Lugar_entrega_del_contenedor { get; set; } = null!;
}
