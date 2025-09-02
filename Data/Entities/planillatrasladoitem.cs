using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class planillatrasladoitem
{
    [Key]
    public int idplanillatrasladoitems { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? concepto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? mediotransporte { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? nroidentmediotransporte { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codtipodocsalida { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? nrodocsalida { get; set; }

    public bool? mciatrasladadatotalmente { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? grupo { get; set; }

    public int? codtipocarga { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codtipounidadcarga { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? identificacionunidadcarga { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codtipodocviajeinternacional { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? doctransporteinternacional { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadoctransporte { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? nrobultos { get; set; }

    public int? idembalaje { get; set; }

    public int? idtransportador { get; set; }

    public int? idplanillatraslado { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? nroprecinto { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? codtamañocontenedor { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tipoequipo { get; set; }

    public int? iddatoserie { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? mciaperecedera { get; set; }
}
