using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ServiciosPorTarifa")]
public partial class ServiciosPorTarifa
{
    [Key]
    public int Id { get; set; }

    public int? IdTarifario { get; set; }

    [Unicode(false)]
    public string? Tipo { get; set; }

    [Unicode(false)]
    public string? NombreServicio { get; set; }
}
