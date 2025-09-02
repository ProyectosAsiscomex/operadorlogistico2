using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Datosserie")]
public partial class Datosserie
{
    [Key]
    public int iddatoserie { get; set; }

    public int? Grupo { get; set; }

    public int? idsubpartidas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigocomplementario { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigosuplementario { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigounidadfisica { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Cantidadunidadfisica { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigounidadcomercial { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Cantidadunidadcomercial { get; set; }

    public int? idembalaje { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Nrobultos { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Pesobruto { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? ValorFOB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Marcas { get; set; }

    [Unicode(false)]
    public string? DescripcionMcia { get; set; }

    public int? idunidadmedidaplazo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? plazo { get; set; }

    public int? idpaisorigen { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigoregionorigen { get; set; }

    public int? idpreferenciaarancelaria { get; set; }

    public int? idautorizacionembarque { get; set; }

    public int? idaduanaprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodeclaracionprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? añoaceptacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codregprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codmodprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroserieprecedente { get; set; }

    public int? idsolicitudcliente { get; set; }

    public short? serie { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? cantidadcliente { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobcliente { get; set; }

    [StringLength(500)]
    public string? comentario { get; set; }

    [StringLength(70)]
    public string? VariedadNotaCargue { get; set; }

    public int? idproducto { get; set; }

    public string? agrupa { get; set; }

    public int? nrosubpartidaprecedente { get; set; }

    public bool? edicionmanual { get; set; }
}
