using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Despacho
{
    [Key]
    public int iddespacho { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechadespacho { get; set; }

    public int? idorden { get; set; }

    public int? idimportador { get; set; }

    [StringLength(50)]
    public string? nrodespacho { get; set; }

    public int? idfacturaimpo { get; set; }

    public int? idproveedor { get; set; }

    public int? idlugarembarque { get; set; }

    public int? idlugardestino { get; set; }

    [StringLength(50)]
    public string? documentooperativo { get; set; }

    public int? idvia { get; set; }

    public int? cmbidpais { get; set; }

    public int? idciudadentrega { get; set; }

    [StringLength(500)]
    public string? observaciones { get; set; }
}
