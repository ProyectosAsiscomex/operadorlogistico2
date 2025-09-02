using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_TransitoAduaneroDetalle")]
public partial class tb_TransitoAduaneroDetalle
{
    [Key]
    public int idDetalleTransito { get; set; }

    [Unicode(false)]
    public string? TipoNaturalezaDescripcionMercancia { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CantidadBultos { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NumerodeidentificacionUnidad { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Precintable { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PrecintoNumero { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? PesobrutoDeclarado { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? PesoCargaVerificado { get; set; }

    public int? idTrancito { get; set; }
}
