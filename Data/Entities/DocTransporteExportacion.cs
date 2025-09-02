using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DocTransporteExportacion")]
public partial class DocTransporteExportacion
{
    [Key]
    public int idDocTransporteExportacion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pedido { get; set; }

    public byte? idnaviera { get; set; }

    public short? idembarcador { get; set; }

    public byte? idnotificar { get; set; }

    public short? idconsignatario { get; set; }

    public short? idaduanas { get; set; }

    public short? idpuertocarga { get; set; }

    public int? idlugarembarque { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? buque { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? viaje { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? marcas { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? descripcion { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesobruto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? pesoneto { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? nrobultos { get; set; }

    [Column(TypeName = "decimal(30, 2)")]
    public decimal? medicion { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? factura { get; set; }

    public bool? radiofletes { get; set; }
}
