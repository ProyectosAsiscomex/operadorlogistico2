using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class Costos_Exportacione
{
    [Column("do")]
    public int? _do { get; set; }

    public int? exportador1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mes { get; set; }

    public int? modalidad1 { get; set; }

    public int? pedido1 { get; set; }

    public int? aduana1 { get; set; }

    public int? pais { get; set; }

    public int? Destino { get; set; }

    public int? naviera1 { get; set; }

    public int? Tipo { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? exportador { get; set; }

    [Column("Carga peligrosa")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Carga_peligrosa { get; set; }

    [StringLength(50)]
    public string? modalidad { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? pedido { get; set; }

    [StringLength(100)]
    public string? aduana { get; set; }

    [Column("pais destino")]
    [StringLength(50)]
    public string? pais_destino { get; set; }

    [Column("destino final")]
    [StringLength(200)]
    [Unicode(false)]
    public string? destino_final { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? naviera { get; set; }

    [Column("tipo carga")]
    [StringLength(200)]
    [Unicode(false)]
    public string? tipo_carga { get; set; }

    public int? Tamaño1 { get; set; }

    [Column("Tipo Equipo1")]
    public int? Tipo_Equipo1 { get; set; }

    public int? CantCont { get; set; }

    [Column("Peso neto", TypeName = "decimal(30, 2)")]
    public decimal? Peso_neto { get; set; }

    [Column("Tamaño contenedor")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Tamaño_contenedor { get; set; }

    [Column("Tipo equipo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Tipo_equipo { get; set; }

    public string? Facturas { get; set; }

    [Column("Flete nacional", TypeName = "money")]
    public decimal? Flete_nacional { get; set; }

    [Column("Movimiento contenedor", TypeName = "money")]
    public decimal? Movimiento_contenedor { get; set; }

    [Column("Uso de Instalaciones", TypeName = "money")]
    public decimal? Uso_de_Instalaciones { get; set; }

    [Column("Flete nacional 2", TypeName = "money")]
    public decimal? Flete_nacional_2 { get; set; }

    [Column("Recargo carga peligrosa", TypeName = "money")]
    public decimal? Recargo_carga_peligrosa { get; set; }

    [Column("Cargue/Descargue Camion", TypeName = "money")]
    public decimal? Cargue_Descargue_Camion { get; set; }

    [Column(TypeName = "money")]
    public decimal? Pesaje { get; set; }

    [Column(TypeName = "money")]
    public decimal? Mounting { get; set; }

    [Column("Operador Logistico INVIMA", TypeName = "money")]
    public decimal? Operador_Logistico_INVIMA { get; set; }

    [Column("Movilización Inspección INVIMA", TypeName = "money")]
    public decimal? Movilización_Inspección_INVIMA { get; set; }

    [Column("Comisión Aduana", TypeName = "money")]
    public decimal? Comisión_Aduana { get; set; }

    [Column("Costo Total", TypeName = "money")]
    public decimal? Costo_Total { get; set; }

    [Column("Flete Internacional", TypeName = "money")]
    public decimal? Flete_Internacional { get; set; }

    [Column("Alquiler Isotanques", TypeName = "money")]
    public decimal? Alquiler_Isotanques { get; set; }

    [Column("Costo Total 2", TypeName = "money")]
    public decimal? Costo_Total_2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Almacenamiento { get; set; }

    [Column("Inspección Antinarcoticos", TypeName = "money")]
    public decimal? Inspección_Antinarcoticos { get; set; }

    [Column("Movilización Inspección Antinarcoticos", TypeName = "money")]
    public decimal? Movilización_Inspección_Antinarcoticos { get; set; }

    [Column("Operador logistico antinarcoticos", TypeName = "money")]
    public decimal? Operador_logistico_antinarcoticos { get; set; }

    [Column("Total Sobre Costos", TypeName = "money")]
    public decimal? Total_Sobre_Costos { get; set; }

    [Column("Total Costos Logisticos", TypeName = "money")]
    public decimal? Total_Costos_Logisticos { get; set; }
}
