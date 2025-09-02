using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ConsultaAsiscomex")]
public partial class ConsultaAsiscomex
{
    [Key]
    public int idConsultaAsiscomex { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Unicode(false)]
    public string? Consulta { get; set; }
}
