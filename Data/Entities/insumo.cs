using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class insumo
{
    [Key]
    public int idinsumo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? descdeclaracion { get; set; }

    public int? idarancel { get; set; }

    public int? idunidad { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ci { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? FACTORDIAN { get; set; }

    public int? IDUNIDADDIAN { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? peso { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? volumen { get; set; }

    public bool? vehiculo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? codigoant { get; set; }

    [StringLength(100)]
    public string? ABC { get; set; }

    public bool? bloqueado { get; set; }

    public int? idunidadempaque { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? factorempaque { get; set; }

    [StringLength(50)]
    public string? codigounico { get; set; }

    public int? idpais { get; set; }

    [StringLength(1000)]
    public string? descripcionerp { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaactualizacion { get; set; }
}
