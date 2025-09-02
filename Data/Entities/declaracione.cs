using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class declaracione
{
    [Key]
    public int iddeclaracion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? auxiliar { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? sticker { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaaux { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechasticker { get; set; }

    public int? idaduana { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? factura { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechafac { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? nrolevante { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechalev { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? doctrans { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadoc { get; set; }

    public int? idproveedor { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? comentario { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? tasaotram { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? trm { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? porarancel { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? iva { get; set; }

    [Column(TypeName = "money")]
    public decimal? vrotram { get; set; }

    [Column(TypeName = "money")]
    public decimal? vrfob { get; set; }

    [Column(TypeName = "money")]
    public decimal? fletes { get; set; }

    [Column(TypeName = "money")]
    public decimal? seguro { get; set; }

    [Column(TypeName = "money")]
    public decimal? otrosgastos { get; set; }

    [Column(TypeName = "money")]
    public decimal? ajusteus { get; set; }

    [Column(TypeName = "money")]
    public decimal? arancelus { get; set; }

    public int? idmoneda { get; set; }

    public int? idimportador { get; set; }

    public int? idcarpeta { get; set; }

    [Column(TypeName = "money")]
    public decimal? totaliva { get; set; }

    public int? IDREGIONAL { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? cantidad { get; set; }

    public int? idinsumo { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? pesoneto { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? aceptacion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? faceptacion { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? otrasoperaciones { get; set; }

    [Column(TypeName = "money")]
    public decimal? nuevofob { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? nrooficio { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? tipooperacion { get; set; }

    [Column(TypeName = "money")]
    public decimal? vraduana { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? OTRASCANT { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? NUEVACANT { get; set; }

    [StringLength(50)]
    public string? OFDIAN { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? CANTOF { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? OFOTRAS { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? EXCAPLICA { get; set; }

    [StringLength(50)]
    public string? TIPO { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FOFICIO { get; set; }

    [StringLength(50)]
    public string? numerodoc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechanumdoc { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidaddoc { get; set; }

    [StringLength(50)]
    public string? NUMCANCEL { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FECHACANCEL { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? CANTCANCEL { get; set; }

    public int? IdRegistro { get; set; }

    public int? idInsumoRegistro { get; set; }
}
