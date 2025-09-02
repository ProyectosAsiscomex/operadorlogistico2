using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Ordendecompra")]
public partial class Ordendecompra
{
    [Key]
    public int idordendecompra { get; set; }

    [StringLength(50)]
    public string? orden { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaorden { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadespacho { get; set; }

    [StringLength(50)]
    public string? cotizacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechacotizacion { get; set; }

    public int? idcarpeta { get; set; }

    public int? idaduana { get; set; }

    public int? idproveedor { get; set; }

    public int? idincoterm { get; set; }

    public int? idimportador { get; set; }

    public int? idcomisionista { get; set; }

    public int? idembarcador { get; set; }

    public int? idaseguradora { get; set; }

    public int? idmoneda { get; set; }

    public int? idvia { get; set; }

    public int? idreembolzo { get; set; }

    public int? idlugarembarque { get; set; }

    [StringLength(10)]
    public string? idlugardestino { get; set; }

    [Column(TypeName = "money")]
    public decimal? trm { get; set; }

    [Column(TypeName = "money")]
    public decimal? fletes { get; set; }

    [Column(TypeName = "money")]
    public decimal? gastos { get; set; }

    public bool? cancelado { get; set; }

    public bool? cerrado { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? nestado { get; set; }

    [StringLength(50)]
    public string? auxiliar { get; set; }

    public int? origen { get; set; }

    public int? vehiculo { get; set; }

    public bool? zonafranca { get; set; }

    public int? idcategoria { get; set; }

    public int? idusuario { get; set; }

    [StringLength(250)]
    public string? observacionesenca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? horamodificacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? tasa { get; set; }

    public int? idconsignatario { get; set; }

    public int? idpaisorigen { get; set; }

    public int? idpaisdecompra { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharecibooc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaposibleembarque { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaconfirmacionembarque { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ntipo { get; set; }

    public int? idpaisdestino { get; set; }

    public int? cmbidpais { get; set; }

    public bool? planvallejo { get; set; }

    public bool? registroimpo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? condicionespago { get; set; }

    public bool? estado { get; set; }

    public bool? revisado { get; set; }

    [Column(TypeName = "money")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobrutoprorrateado { get; set; }

    public int? IDLISTACHEQUEO { get; set; }
}
