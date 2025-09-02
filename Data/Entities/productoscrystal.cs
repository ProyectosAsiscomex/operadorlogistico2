using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("productoscrystal")]
public partial class productoscrystal
{
    [Key]
    public int idproducto { get; set; }

    public int? idimportador { get; set; }

    public bool habilitado { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }

    [StringLength(200)]
    public string? nombrecomercial { get; set; }

    [StringLength(200)]
    public string? otrascaracteristicas { get; set; }

    [StringLength(200)]
    public string? marca { get; set; }

    [StringLength(200)]
    public string? referencia { get; set; }

    public string? descminimasmincomex { get; set; }

    [StringLength(200)]
    public string? bd { get; set; }

    public int? idarancel { get; set; }

    [StringLength(200)]
    public string? nombreimportador { get; set; }

    [StringLength(200)]
    public string? subpartida { get; set; }

    public int? idexportador { get; set; }

    [StringLength(200)]
    public string? nombreexportador { get; set; }

    public int? idib { get; set; }
}
