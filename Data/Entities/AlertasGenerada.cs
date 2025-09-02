using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AlertasGenerada
{
    [Key]
    public int idAlertasGeneradas { get; set; }

    public int? idactivacionalertas { get; set; }

    public int? idestado { get; set; }

    public int? idDo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha { get; set; }

    [StringLength(400)]
    public string? tipo { get; set; }

    public string? valor { get; set; }
}
