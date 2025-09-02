using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("logTransaccionCambioDo")]
public partial class logTransaccionCambioDo
{
    [StringLength(50)]
    public string? DoInicial { get; set; }

    [StringLength(50)]
    public string? DoFinal { get; set; }

    public int? idUsuario { get; set; }

    [StringLength(3000)]
    public string? Comentario { get; set; }
}
