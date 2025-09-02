using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AsuntosCorreoEnviadoPorDO")]
public partial class AsuntosCorreoEnviadoPorDO
{
    [Key]
    public int Id { get; set; }

    public int? IdDO { get; set; }

    [Unicode(false)]
    public string? NombreAsunto { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }
}
