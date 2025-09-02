using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("Documentossoporte")]
public partial class Documentossoporte
{
    [Key]
    public int iddocumento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nrodocumento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nitemisor { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechaexpedicion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fechavencimiento { get; set; }

    public int? idmoneda { get; set; }

    [Column(TypeName = "decimal(30, 15)")]
    public decimal? Montodocumento { get; set; }

    public int? idunidadcomercial { get; set; }

    [Column(TypeName = "decimal(20, 10)")]
    public decimal? Cantidad { get; set; }

    public int? idautorizacionembarque { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? dvemisor { get; set; }

    public int? iddocumentosoporte { get; set; }

    public int? idsolicitudcliente { get; set; }
}
