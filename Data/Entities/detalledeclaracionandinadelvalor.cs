using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("detalledeclaracionandinadelvalor")]
public partial class detalledeclaracionandinadelvalor
{
    [Key]
    public int iddetalledeclaandinavalor { get; set; }

    public int? iddeclaandina { get; set; }

    [Column(TypeName = "decimal(30, 6)")]
    public decimal? cantidad { get; set; }

    [Column(TypeName = "decimal(30, 8)")]
    public decimal? precioFOB { get; set; }

    public int? idproductoimpo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? codestado { get; set; }

    public int? idordendecompraitem { get; set; }

    public int? iddetallefacturaimportacion { get; set; }

    public int? iddocumentotransporteitem { get; set; }

    public int? iddeclaracionimportacion { get; set; }

    public int? idandinavaloritem { get; set; }

    public int? idregistroimpoitem { get; set; }

    public int? iddespachoitem { get; set; }

    public int? idunidadcomercial { get; set; }
}
