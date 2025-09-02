using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("productosibcontrol")]
public partial class productosibcontrol
{
    [Key]
    public int idproductosibcontrol { get; set; }

    public int? idproductoIB { get; set; }

    public int? IDIMPORTADORIB { get; set; }

    public string? IMPORTADOR { get; set; }

    public int? idimportador { get; set; }

    public int? IDEXPORTADORIB { get; set; }

    public string? EXPORTADORib { get; set; }

    public int? exportador { get; set; }

    [StringLength(50)]
    public string? habilitadoIB { get; set; }

    public bool? habilitado { get; set; }

    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? POSICION { get; set; }

    public int? idarancel { get; set; }

    [Unicode(false)]
    public string? nombrecomercial { get; set; }

    [Unicode(false)]
    public string? otrascaracteristicas { get; set; }

    [Unicode(false)]
    public string? observaciones { get; set; }

    [Unicode(false)]
    public string? marca { get; set; }

    [Unicode(false)]
    public string? referencia { get; set; }

    [Unicode(false)]
    public string? DescMinimasMincomex { get; set; }

    [Unicode(false)]
    public string? bd { get; set; }

    [Unicode(false)]
    public string? ucomercial { get; set; }

    [Unicode(false)]
    public string? udian { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? IDEXPORTADOR { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NITIMPORTADOR { get; set; }

    public int? iducomercial { get; set; }

    public bool? NOTRASLADADOS { get; set; }
}
