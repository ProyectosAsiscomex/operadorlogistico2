using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class perfile
{
    [Key]
    public int id_perfil { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }
}
