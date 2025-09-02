using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("vistosBuenosxProducto")]
public partial class vistosBuenosxProducto
{
    [Key]
    public int idVistoBuenoxProducto { get; set; }

    public int? idRegistroItem { get; set; }

    public int? idVistoBueno { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaExpedicion { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechaVigencia { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? referencia { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombreCortoEntidad { get; set; }
}
