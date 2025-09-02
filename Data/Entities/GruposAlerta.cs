using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class GruposAlerta
{
    [Key]
    public int IdGrupo { get; set; }

    [StringLength(50)]
    public string? CodigoGrupo { get; set; }

    [StringLength(200)]
    public string? NombreGrupo { get; set; }
}
