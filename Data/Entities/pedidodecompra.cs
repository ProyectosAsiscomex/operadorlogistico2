using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("pedidodecompra")]
public partial class pedidodecompra
{
    [Key]
    public int idpedidodecompra { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Pedido { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nroPedido { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaEmisionPedido { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaPedido { get; set; }

    public short? idexportador { get; set; }

    public short? idComprador { get; set; }

    public short? idincoterm { get; set; }

    public int? idlugardestino { get; set; }

    public short? idvia { get; set; }

    public short? cmbidpais { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? total { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nroentrega { get; set; }

    public short? idaduana { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? observaciones { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? sac { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecharequeridacliente { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaprometidaproduccion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaconfirmacionpedido { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? proyecto { get; set; }

    public byte? calificacion { get; set; }

    public byte? calidad { get; set; }

    public byte? documentacion { get; set; }

    public byte? servicio { get; set; }

    public byte? analisis { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? causales { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? responsable { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? causalesIndicador { get; set; }
}
