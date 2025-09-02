using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("NotaRemisoriadetalle")]
public partial class NotaRemisoriadetalle
{
    [Key]
    public int idNotadetalle { get; set; }

    public int? idNotaRemisoria { get; set; }

    public int? idDetalleContenedor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BodegaLocal { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? LugarEntregaDestino { get; set; }

    public int? idDepartamentodestino { get; set; }

    public int? IdCiudadDestino { get; set; }

    public int? idTransportadorNal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Devolver { get; set; }

    [Column(TypeName = "money")]
    public decimal? ValorFlete { get; set; }

    [Column(TypeName = "money")]
    public decimal? Devolucion { get; set; }

    [Column(TypeName = "money")]
    public decimal? Recargo { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Volumen { get; set; }

    public int? NroBultos { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? valorBodega { get; set; }
}
