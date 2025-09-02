using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_perfilesxusuario")]
public partial class tb_perfilesxusuario
{
    [Key]
    public int id { get; set; }

    public int? idPerfil { get; set; }

    public int? idUsuario { get; set; }
}
