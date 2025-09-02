using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("correspondenciaSucursal")]
public partial class correspondenciaSucursal
{
    [Key]
    public int idCorrespondencia { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fechayhora { get; set; }

    public int? idciudadOrigen { get; set; }

    public int? idusuario { get; set; }

    public int? idciudadDestino { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? detalle { get; set; }

    public int? idempresa { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? detalleenvio { get; set; }

    public bool? confidencial { get; set; }
}
