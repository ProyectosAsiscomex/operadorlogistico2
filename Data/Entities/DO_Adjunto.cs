using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class DO_Adjunto
{
    [Key]
    public int idAdjunto { get; set; }

    public int? idDO { get; set; }

    [StringLength(500)]
    public string? ruta { get; set; }

    [StringLength(500)]
    public string? archivo { get; set; }

    public int? idusuario { get; set; }

    [StringLength(500)]
    public string? comentario { get; set; }
}
