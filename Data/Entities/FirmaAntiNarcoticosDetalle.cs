using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("FirmaAntiNarcoticosDetalle")]
public partial class FirmaAntiNarcoticosDetalle
{
    [Key]
    public int idfirmaantinarcoticosdetalle { get; set; }

    public int? idfirmaantinarcoticos { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cedula { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? lugarexpedicion { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? cargo { get; set; }
}
