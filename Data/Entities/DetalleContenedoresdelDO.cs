using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleContenedoresdelDO")]
public partial class DetalleContenedoresdelDO
{
    [Key]
    public int idDetalleContenedoresDO { get; set; }

    public int? idDo { get; set; }

    public int? idTamanioContenedor { get; set; }

    public int? idTipoEquipo { get; set; }

    public int? cantidad { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? idcontenedor { get; set; }

    [Unicode(false)]
    public string? Sellos { get; set; }

    public int? IdDetalleMercanciaCotizacion { get; set; }

    [Unicode(false)]
    public string? SellosAdhesivo { get; set; }

    [Unicode(false)]
    public string? SellosBotella { get; set; }

    [Unicode(false)]
    public string? SellosGuaya { get; set; }

    [Unicode(false)]
    public string? Temperatura { get; set; }

    [Unicode(false)]
    public string? Ventilacion { get; set; }

    [Unicode(false)]
    public string? Humedad { get; set; }
}
