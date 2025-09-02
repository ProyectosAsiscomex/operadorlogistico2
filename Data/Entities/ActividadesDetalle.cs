using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ActividadesDetalle")]
public partial class ActividadesDetalle
{
    [Key]
    public int idActividadItem { get; set; }

    public int? idActividad { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Valor { get; set; }
}
