using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class FirmaAntiNarcotico
{
    [Key]
    public int idfirmaantinarcoticos { get; set; }

    public int? idcompania { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? cedula { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? lugarexpedicion { get; set; }
}
