using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("productosib")]
public partial class productosib
{
    [Key]
    public int idproducto { get; set; }

    public int? idimportador { get; set; }

    public bool? habilitado { get; set; }

    [Unicode(false)]
    public string? codigo { get; set; }

    public string? nombrecomercial { get; set; }

    public string? otrascaracteristicas { get; set; }

    public string? marca { get; set; }

    public string? referencia { get; set; }

    public string? DescMinimasMincomex { get; set; }

    public string? BD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? idarancel { get; set; }

    [Unicode(false)]
    public string? nombreimportador { get; set; }

    [Unicode(false)]
    public string? subpartida { get; set; }

    public int? idexportador { get; set; }

    [Unicode(false)]
    public string? nombreexportador { get; set; }
}
